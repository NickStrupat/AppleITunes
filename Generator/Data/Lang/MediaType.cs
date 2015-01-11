using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Generator.Data.Lang {
    public class MediaType {
        public String Key { get; set; }
        public String Text { get; set; }

        public static async Task<IDictionary<String, String>> GetAsync() {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://rss.itunes.apple.com/data/lang/en-US/media-types.json");
            return JsonConvert.DeserializeObject<IDictionary<String, String>>(json);
        }
    }
}
