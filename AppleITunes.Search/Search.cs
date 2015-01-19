using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleITunes
{
    public partial class Search
    {
	    public enum Media {
		    Movie, Podcast, Music, MusicVideo, Audiobook, ShortFilm, TvShow, Software, Ebook, All
	    }

	    public enum Entity {
		    MovieArtist, Movie,
			PodcastAuthor, Podcast,
			MusicArtist, MusicTrack, Album, MusicVideo, Mix, Song,
			AudiobookAuthor, Audiobook,
			ShortFilmArtist, ShortFilm,
			TvEpisode, TvSeason,
			Software, IPadSoftware, MacSoftware,
			Ebook,
			AllArtist, AllTrack
	    }

	    public enum Language {
		    English, Japanese
	    }

	    public Search(
			Country country,
			Media media = Media.All,
			Entity? entity = null,
			Byte limit = 50,
			Language language = Language.English,
			Boolean includeExplicitResults = true
		)
		{ }

	    public void GetResults() {
		    
	    }
    }
}
