using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Generator.Data {
    public class Country {
        [JsonProperty("translation_key")]
        public String TranslationKey { get; set; }
        [JsonProperty("country_code")]
        public String CountryCode { get; set; }
        [JsonProperty("currency_format")]
        public String CurrencyFormat { get; set; }
        [JsonProperty("currency_seperator")]
        public String CurrencySeperator { get; set; }
        public Boolean Decimal { get; set; }
        [JsonProperty("default_price")]
        public Double DefaultPrice { get; set; }
        public Boolean Enabled { get; set; }
        [JsonProperty("flag_icon")]
        public String FlagIcon { get; set; }
        public String Language { get; set; }
        public String NavBar { get; set; }
        [JsonProperty("search_country")]
        public String SearchCountry { get; set; }
        public String Region { get; set; }
        public IDictionary<String, Boolean> Stores { get; set; }

        public static async Task<IEnumerable<Country>> GetAsync() {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://rss.itunes.apple.com/data/countries.json");
            return JsonConvert.DeserializeObject<IEnumerable<Country>>(json);
        }
    }
}
