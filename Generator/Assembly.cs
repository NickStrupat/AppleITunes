using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Generator.Data;
using Generator.Data.Lang;

namespace Generator {
    public static class Assembly {
        public static String ToPascalCase(this String @string) {
            @string = @string.Replace("&", " And ").Replace("/", " ");
            var capitalizedWords = from token in @string.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   select token.Substring(0, 1).ToUpper() + token.Substring(1).ToLower();
            var joinedWords = String.Join(String.Empty, capitalizedWords.ToArray());
            foreach (var characterToRemove in " .,-'")
                joinedWords = joinedWords.Replace(characterToRemove.ToString(), String.Empty);
            return joinedWords;
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
            //var musicFeedTypes = from musicFeedType in mediaTypes.FeedTypesForStore("music").Translations(langMediaTypes)
            //                     select musicFeedType.ToPascalCase();

            //var mediaTypes2 = (from mediaType in mediaTypesTask.Result
            //                   join langMediaType in langMediaTypesTask.Result
            //                   on mediaType.TranslationKey equals langMediaType.Key
            //                   select new {
            //                       Name = langMediaType.Value.ToPascalCase(),
            //                       DisplayText = langMediaType.Value
            //                   }).ToArray();
            
            //var feeds2 = from country in countries
            //            join feedCountry in langCommon.FeedCountries
            //            on country.CountryCode equals feedCountry.Code
            //            from feedType in mediaTypes.Select(x => x.FeedTypes)
            //            from genre in mediaTypes.Select(x => x.SubGenres).Single().
            //            select String.Format("https://itunes.apple.com/{0}/rss/{1}/{2}", country.CountryCode, );
            //feeds2.ToArray();

            /*var feeds = new List<Object>();
            foreach (var country in from country in countries
                                    join feedCountry in langCommon.FeedCountries
                                    on country.CountryCode equals feedCountry.Key
                                    select new { Country = country, FeedCountry = feedCountry }) {
                foreach (var store in country.Country.Stores.Where(x => x.Value).Select(x => x.Key)) {
                    foreach (var mediaType in mediaTypes.Where(x => x.Store == store)) {
                        foreach (var feedType in mediaType.FeedTypes) {
                            foreach (var genre in mediaType.SubGenres) {
                                foreach (var explicitContent in new[] {false, true}) {
                                    const Int32 limit = 300;
                                    var parameters = String.Format("limit={0}{1}/explicit={2}", limit, String.IsNullOrWhiteSpace(genre.Id) ? "/genre=" + genre.Id : String.Empty, explicitContent.ToString().ToLower());
                                    feeds.Add(new {
                                                      Country = AppleITunes.Country.Parse(typeof(Country), country.FeedCountry.Value.ToPascalCase()),
                                                      MediaType = mediaType.TranslationKey,
                                                      FeedType = feedType.TranslationKey,
                                                      Genre = genre.TranslationKey,
                                                      ExplicitContent = explicitContent,
                                                      Url = feedType.UrlPrefix.Replace("<%= country_code %>", country.Country.CountryCode).Replace("<%= parameters %>", parameters) + "/" + feedType.UrlSuffix
                                                  });
                                }
                            }
                        }
                    }
                }
            }*/

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
