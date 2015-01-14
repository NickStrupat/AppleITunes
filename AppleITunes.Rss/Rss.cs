using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Remotion.Linq;
using Remotion.Linq.Clauses;
using Remotion.Linq.Clauses.Expressions;
using Remotion.Linq.Parsing.Structure;
using Remotion.Linq.Parsing;

namespace AppleITunes {
    public static partial class Rss {
        public static IOrderedQueryable<Feed> Feeds { get; private set; }
        static Rss() {
            Feeds = new FeedQueryable<Feed>(QueryParser.CreateDefault()/*new FeedsQueryParser()*/, new FeedQueryExecutor());
        }
        public class Feed {
            public Feed(Country country, MediaType mediaType, FeedType feedType, Genre genre, Boolean explicitContent/*, String uri*/) {
                Country = country;
                MediaType = mediaType;
                FeedType = feedType;
                Genre = genre;
                ExplicitContent = explicitContent;
                //this.uri = uri;
            }
            public readonly Country Country;// { get; private set; }
            public readonly MediaType MediaType;// { get; private set; }
            public readonly FeedType FeedType;// { get; private set; }
            public readonly Genre Genre;// { get; private set; }
            public readonly Boolean ExplicitContent;// { get; private set; }
            //private readonly String uri;

            public DateTime? Retrieved { get; private set; }
            private String uri;
            private SyndicationFeed content;
            public async Task<SyndicationFeed> GetContentAsync(Boolean forceFreshContent = false) {
                if (content == null || forceFreshContent) {
                    if (uri == null) {
                        var genreId = FeedType.GetGenreId(Genre);
                        var parameters = String.Format("limit={0}{1}/explicit={2}", 300, String.IsNullOrWhiteSpace(genreId) ? "/genre=" + genreId : String.Empty, ExplicitContent.ToString().ToLower());
                        uri = FeedType.GetUrlPattern().Replace("<%= country_code %>", Country.GetCode()).Replace("<%= parameters %>", parameters);
                    }
                    using (var httpClient = new HttpClient())
                    using (var xmlReader = XmlReader.Create(await httpClient.GetStreamAsync(uri))) {
                        content = SyndicationFeed.Load(xmlReader);
                        Retrieved = DateTime.Now;
                    }
                }
                return content;
            }
            public SyndicationFeed Content {
                get {
                    var task = GetContentAsync();
                    task.Wait();
                    return task.Result;
                }
            }
        }
    }

    internal class FeedQueryable<T> : QueryableBase<T> {
        public FeedQueryable(IQueryParser queryParser, IQueryExecutor executor) : base(queryParser, executor) {}
        public FeedQueryable(IQueryProvider provider) : base(provider) {}
        public FeedQueryable(IQueryProvider provider, Expression expression) : base(provider, expression) {}
    }

    internal class FeedQueryExecutor : IQueryExecutor {
        public T ExecuteScalar<T>(QueryModel queryModel) {
            return ExecuteCollection<T>(queryModel).Single();
        }
        public T ExecuteSingle<T>(QueryModel queryModel, Boolean returnDefaultWhenEmpty) {
            return returnDefaultWhenEmpty ? ExecuteCollection<T>(queryModel).SingleOrDefault() : ExecuteCollection<T>(queryModel).Single();
        }
        public IEnumerable<T> ExecuteCollection<T>(QueryModel queryModel) {
            var queryModelVisitor = new FeedQueryModelVisitor();
            queryModelVisitor.VisitQueryModel(queryModel);
            return queryModelVisitor.GetFeeds() as IEnumerable<T>;
        }
    }

    internal class FeedQueryModelVisitor : QueryModelVisitorBase {
        internal readonly ICollection<Rss.Country> countries = new List<Rss.Country>();//EnumHelper.GetValues<Country>();
        internal readonly ICollection<Rss.MediaType> mediaTypes = new List<Rss.MediaType>();//EnumHelper.GetValues<MediaType>();
        internal readonly ICollection<Rss.FeedType> feedTypes = new List<Rss.FeedType>();//EnumHelper.GetValues<FeedType>();
        internal readonly ICollection<Rss.Genre> genres = new List<Rss.Genre>();//EnumHelper.GetValues<Genre>();
        internal readonly ICollection<Boolean> explicitContents = new[] { true, false };

        public IEnumerable<Rss.Feed> GetFeeds() {
            return from country in countries.Any() ? countries : EnumHelper.GetValues<Rss.Country>()
                   from mediaType in mediaTypes.Any() ? mediaTypes : EnumHelper.GetValues<Rss.MediaType>()
                   from feedType in feedTypes.Any() ? feedTypes : EnumHelper.GetValues<Rss.FeedType>()
                   from genre in genres.Any() ? genres : EnumHelper.GetValues<Rss.Genre>()
                   from explicitContent in explicitContents
                   select new Rss.Feed(country, mediaType, feedType, genre, explicitContent);
        } 

        public override void VisitMainFromClause(MainFromClause fromClause, QueryModel queryModel) {
            base.VisitMainFromClause(fromClause, queryModel);
            //queryModel.MainFromClause
        }
        private Func<Rss.Country, Rss.MediaType, Rss.FeedType, Rss.Genre, Boolean, Boolean> filter; 
        public override void VisitWhereClause(WhereClause whereClause, QueryModel queryModel, Int32 index) {
            base.VisitWhereClause(whereClause, queryModel, index);
            //var expressionParameters = new[] {
            //                                     Expression.Parameter(typeof (Country)),
            //                                     Expression.Parameter(typeof (MediaType)),
            //                                     Expression.Parameter(typeof (FeedType)),
            //                                     Expression.Parameter(typeof (Genre)),
            //                                     Expression.Parameter(typeof (Boolean)),
            //                                 };
            //filter = Expression.Lambda<Func<Country, MediaType, FeedType, Genre, Boolean, Boolean>>(whereClause.Predicate, expressionParameters).Compile();
            //var countries = EnumHelper.GetValues<Country>();
            //var mediaTypes = EnumHelper.GetValues<MediaType>();
            //var feedTypes = EnumHelper.GetValues<FeedType>();
            //var genres = EnumHelper.GetValues<Genre>();
            var visitor = new FeedExpressionTreeVisitor(this);
            visitor.VisitExpression(whereClause.Predicate);
        }
    }

    internal class FeedExpressionTreeVisitor : ThrowingExpressionTreeVisitor { 
        private readonly FeedQueryModelVisitor feedQueryModelVisitor;
        private readonly Stack<Type> convertTypes = new Stack<Type>();
        private readonly Stack<Int32> constants = new Stack<Int32>();

        public FeedExpressionTreeVisitor(FeedQueryModelVisitor feedQueryModelVisitor) {
            this.feedQueryModelVisitor = feedQueryModelVisitor;
        }

        protected override Exception CreateUnhandledItemException<T>(T unhandledItem, String visitMethod) {
            return new Exception(typeof (T).Name + " unhandled by " + visitMethod);
        }

        private void unaryAndConstant(UnaryExpression unaryExpression, ConstantExpression constantExpression) {
            
        }

        protected override Expression VisitBinaryExpression(BinaryExpression expression) {
            var unary = expression.Left as UnaryExpression ?? expression.Right as UnaryExpression;
            var constant = expression.Left as ConstantExpression ?? expression.Right as ConstantExpression;
            Type type = null;
            Int32 value = 0;
            if (unary != null && unary.NodeType == ExpressionType.Convert) {
                type = unary.Operand.Type;
            }
            if (constant != null && constant.Type == typeof(Int32)) {
                value = (Int32) constant.Value;
            }
            if (type == typeof(Rss.Country))
                feedQueryModelVisitor.countries.Add((Rss.Country)value);
            else if (type == typeof(Rss.MediaType))
                feedQueryModelVisitor.mediaTypes.Add((Rss.MediaType)value);
            else if (type == typeof(Rss.FeedType))
                feedQueryModelVisitor.feedTypes.Add((Rss.FeedType)value);
            else if (type == typeof(Rss.Genre))
                feedQueryModelVisitor.genres.Add((Rss.Genre)value);
            VisitExpression(expression.Left);
            VisitExpression(expression.Right);
            return /*base.VisitBinaryExpression*/(expression);
        }

        protected override Expression VisitLambdaExpression(LambdaExpression expression) {
            return base.VisitLambdaExpression(expression);
        }

        protected override Expression VisitUnaryExpression(UnaryExpression expression) {
            if (expression.NodeType == ExpressionType.Convert)
                convertTypes.Push(expression.Operand.Type);
            return /*base.VisitUnaryExpression*/(expression);
        }
        protected override Expression VisitConstantExpression(ConstantExpression expression) {
            if (expression.Type == typeof(Int32))
                constants.Push((Int32)expression.Value);
            return /*base.VisitConstantExpression*/(expression);
        }
        protected override Expression VisitSubQueryExpression(SubQueryExpression expression) {
            return base.VisitSubQueryExpression(expression);
        }
    }

    //internal class FeedsQueryParser : IQueryParser {
    //    public QueryModel GetParsedQuery(Expression expressionTreeRoot) {
    //        throw new NotImplementedException();
    //    }
    //}
}
