using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Generator.Data.Lang {
    public class Common {
        public String Country { get; set; }
        [JsonProperty("Feed_Type")]
        public String FeedType { get; set; }
        public String Genre { get; set; }
        [JsonProperty("Media_Type")]
        public String MediaType { get; set; }
        public String Size { get; set; }
        [JsonProperty("feed_country")]
        public IDictionary<String, String> FeedCountries { get; set; }
        public String Yes { get; set; }
        public String No { get; set; }

        public static async Task<Common> GetAsync() {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://rss.itunes.apple.com/data/lang/en-US/common.json");
            return JsonConvert.DeserializeObject<Common>(json);
        }
    }
}
