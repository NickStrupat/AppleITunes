using System.ComponentModel;

namespace AppleITunes {
	public static partial class Rss {
		public enum MediaType {
			[Description("Audiobooks")]
			Audiobooks,
			[Description("iOS Apps")]
			IosApps,
			[Description("Movies")]
			Movies,
			[Description("Music")]
			Music,
			[Description("Mac Apps")]
			MacApps,
			[Description("Podcasts")]
			Podcasts,
			[Description("Books")]
			Books,
			[Description("iTunesU")]
			Itunesu,
			[Description("TV Shows")]
			TvShows,
			[Description("Music Videos")]
			MusicVideos,
		}
	}
}