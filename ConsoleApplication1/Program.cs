using System.CodeDom.Compiler;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AppleITunes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication1 {
    class Program {
        static void Main(String[] args) {
            //Generator.Assembly.Generate();
            //return;
            //AppleITunesRss.Canada.Music.NewReleases.All
            //var count = Rss.Feeds.Count();
            var countries = EnumHelper.GetValues<Rss.Country>();
            var newReleases = from feed in AppleITunes.Rss.Feeds
                              where feed.Country == Rss.Country.Canada || feed.Country == Rss.Country.UnitedStates
                              where feed.MediaType == Rss.MediaType.Music
                              //where feed.Genre == Genre.Blues
							  where feed.FeedType == Rss.FeedType.NewReleases
                                 && new[] { Rss.Genre.Blues, Rss.Genre.Classic }.Contains(feed.Genre)
                              select feed;
            var what = newReleases.ToArray();
            var asdf = what.First().Content;
        }
    }
}
