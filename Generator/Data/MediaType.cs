using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Generator.Data {
    public class MediaType {
        public Boolean CanBeExplicit { get; set; }
        [JsonProperty("feed_types")]
        public List<FeedType> FeedTypes { get; set; }
        public String Id { get; set; }
        public String Store { get; set; }
        public List<SubGenre> SubGenres { get; set; }
        [JsonProperty("translation_key")]
        public String TranslationKey { get; set; }

        public static async Task<IEnumerable<MediaType>> GetAsync() {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://rss.itunes.apple.com/data/media-types.json");
            return JsonConvert.DeserializeObject<IEnumerable<MediaType>>(json);
        }
    }

    public class FeedType {
        [JsonProperty("translation_key")]
        public String TranslationKey { get; set; }
        public String UrlPrefix { get; set; }
        public String UrlSuffix { get; set; }
    }

    public class SubGenre {
        public String Id { get; set; }
        [JsonProperty("translation_key")]
        public String TranslationKey { get; set; }
    }
}