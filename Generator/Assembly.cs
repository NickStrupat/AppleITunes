using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generator {
    public static class Assembly {
        public static String ToPascalCase(this String @string) {
            @string = @string.Replace("&", " And ").Replace("/", " ");
            foreach (var characterToRemove in ".,-'()")
				@string = @string.Replace(characterToRemove.ToString(), String.Empty);
            var capitalizedWords = from token in @string.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   select token.Substring(0, 1).ToUpper() + token.Substring(1).ToLower();
            var joinedWords = String.Join(String.Empty, capitalizedWords.ToArray());
            return joinedWords.Replace(" ", String.Empty);
        }

        public static IEnumerable<String> ToPascalCase(this IEnumerable<String> strings) {
            return strings.Select(x => x.ToPascalCase());
        }

        internal static IEnumerable<Data.FeedType> FeedTypesForStore(this IEnumerable<Data.MediaType> mediaTypes, String store) {
            return mediaTypes.Single(x => x.Store == store).FeedTypes;
        }

        internal static IEnumerable<String> Translations(this IEnumerable<Data.FeedType> feedTypes, IEnumerable<Data.Lang.MediaType> langMediaTypes) {
            var translations = from feedType in feedTypes
                               join langMediaType in langMediaTypes
                               on feedType.TranslationKey equals langMediaType.Key
                               select langMediaType.Text;
            return translations;
        }

        public static void Generate() {
            var countriesTask = Data.Country.GetAsync();
            var mediaTypesTask = Data.MediaType.GetAsync();
            var langCommonTask = Data.Lang.Common.GetAsync();
            var langMediaTypesTask = Data.Lang.MediaType.GetAsync();
            Task.WaitAll(countriesTask, mediaTypesTask, langCommonTask, langMediaTypesTask);
            var countries = countriesTask.Result;
            var mediaTypes = mediaTypesTask.Result;
            var langCommon = langCommonTask.Result;
            var langMediaTypes = langMediaTypesTask.Result;

            var feeds = from country in countries
                        join feedCountry in langCommon.FeedCountries
                            on country.CountryCode equals feedCountry.Key
                        from store in country.Stores.Where(x => x.Value).Select(x => x.Key)
                        from mediaType in mediaTypes.Where(x => x.Store == store)
                        join mediaTypeLangMediaType in langMediaTypes
                            on mediaType.TranslationKey equals mediaTypeLangMediaType.Key
                        from feedType in mediaType.FeedTypes
                        join feedTypeLangMediaType in langMediaTypes
                            on feedType.TranslationKey equals feedTypeLangMediaType.Key
                        from genre in mediaType.SubGenres
                        join genreLangMediaType in langMediaTypes
                            on feedType.TranslationKey equals genreLangMediaType.Key
                        from explicitContent in new[] {false, true}
                        let parameters = String.Format("limit={0}{1}/explicit={2}", 300, String.IsNullOrWhiteSpace(genre.Id) ? "/genre=" + genre.Id : String.Empty, explicitContent.ToString().ToLower())
                        select new Tuple<String, String, String, String, String, String>(
                            feedCountry.Value.ToPascalCase(),
                            mediaTypeLangMediaType.Value.ToPascalCase(),
                            feedTypeLangMediaType.Value.ToPascalCase(),
                            genreLangMediaType.Value.ToPascalCase(),
                            explicitContent.ToString().ToLower(),
                            feedType.UrlPrefix.Replace("<%= country_code %>", country.CountryCode).Replace("<%= parameters %>", parameters) + "/" + feedType.UrlSuffix
                            );
            feeds = feeds.ToArray();
            //var classes = from country in countries
            //              join feedCountry in langCommon.FeedCountries
            //              on country.CountryCode equals feedCountry.Code
            //              select new {
            //                  Name = feedCountry.Name.ToPascalCase(),
            //                  DisplayText = feedCountry.Name,
            //                  Apps = !country.Stores.Apps ? null : new { FeedTypes = mediaTypes.FeedTypesForStore("apps").Translations(langMediaTypes).ToPascalCase() },
            //                  Music = !country.Stores.Music ? null : new { FeedTypes = mediaTypes.FeedTypesForStore("music").Translations(langMediaTypes).ToPascalCase() },
            //              };
            //foreach (var @class in classes) {

            //}
        }
    }
}
