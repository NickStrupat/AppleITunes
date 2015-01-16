using System;
using System.ComponentModel;
using System.Linq;

namespace AppleITunes {
	public static partial class Rss {
		public enum FeedType {
			[Description("Top Audiobooks")]
			TopAudiobooks,
			[Description("Top Free Applications")]
			TopFreeApplications,
			[Description("Top Paid Applications")]
			TopPaidApplications,
			[Description("Top Grossing Applications")]
			TopGrossingApplications,
			[Description("Top Free iPad Applications")]
			TopFreeIpadApplications,
			[Description("Top Paid iPad Applications")]
			TopPaidIpadApplications,
			[Description("Top Grossing iPad Applications")]
			TopGrossingIpadApplications,
			[Description("New Applications")]
			NewApplications,
			[Description("New Free Applications")]
			NewFreeApplications,
			[Description("New Paid Applications")]
			NewPaidApplications,
			[Description("Top Movies")]
			TopMovies,
			[Description("Top Video Rentals")]
			TopVideoRentals,
			[Description("Top Albums")]
			TopAlbums,
			[Description("Top iMixes")]
			TopImixes,
			[Description("Top Songs")]
			TopSongs,
			[Description("New Releases")]
			NewReleases,
			[Description("Just Added")]
			JustAdded,
			[Description("Featured Albums")]
			FeaturedAlbums,
			[Description("Top Mac Apps")]
			TopMacApps,
			[Description("Top Free Mac Apps")]
			TopFreeMacApps,
			[Description("Top Grossing Mac Apps")]
			TopGrossingMacApps,
			[Description("Top Paid Mac Apps")]
			TopPaidMacApps,
			[Description("Top Podcasts")]
			TopPodcasts,
			[Description("Top Paid Books")]
			TopPaidBooks,
			[Description("Top Free Books")]
			TopFreeBooks,
			[Description("Top Textbooks")]
			TopTextbooks,
			[Description("Top iTunes U Collections")]
			TopItunesUCollections,
			[Description("Top iTunes U Courses")]
			TopItunesUCourses,
			[Description("Top TV Episodes")]
			TopTvEpisodes,
			[Description("Top TV Seasons")]
			TopTvSeasons,
			[Description("Top Music Videos")]
			TopMusicVideos,
		}
	}

	internal static class FeedTypeExtensions {
		public static String GetUrlPattern(this Rss.FeedType feedType) {
			switch (feedType) {
				case Rss.FeedType.TopAudiobooks:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topaudiobooks/<%= parameters %>/xml";
				case Rss.FeedType.TopFreeApplications:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topfreeapplications/<%= parameters %>/xml";
				case Rss.FeedType.TopPaidApplications:
					return @"https://itunes.apple.com/<%= country_code %>/rss/toppaidapplications/<%= parameters %>/xml";
				case Rss.FeedType.TopGrossingApplications:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topgrossingapplications/<%= parameters %>/xml";
				case Rss.FeedType.TopFreeIpadApplications:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topfreeipadapplications/<%= parameters %>/xml";
				case Rss.FeedType.TopPaidIpadApplications:
					return @"https://itunes.apple.com/<%= country_code %>/rss/toppaidipadapplications/<%= parameters %>/xml";
				case Rss.FeedType.TopGrossingIpadApplications:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topgrossingipadapplications/<%= parameters %>/xml";
				case Rss.FeedType.NewApplications:
					return @"https://itunes.apple.com/<%= country_code %>/rss/newapplications/<%= parameters %>/xml";
				case Rss.FeedType.NewFreeApplications:
					return @"https://itunes.apple.com/<%= country_code %>/rss/newfreeapplications/<%= parameters %>/xml";
				case Rss.FeedType.NewPaidApplications:
					return @"https://itunes.apple.com/<%= country_code %>/rss/newpaidapplications/<%= parameters %>/xml";
				case Rss.FeedType.TopMovies:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topmovies/<%= parameters %>/xml";
				case Rss.FeedType.TopVideoRentals:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topvideorentals/<%= parameters %>/xml";
				case Rss.FeedType.TopAlbums:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topalbums/<%= parameters %>/xml";
				case Rss.FeedType.TopImixes:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topimixes/<%= parameters %>/xml";
				case Rss.FeedType.TopSongs:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topsongs/<%= parameters %>/xml";
				case Rss.FeedType.NewReleases:
					return @"https://itunes.apple.com/WebObjects/MZStore.woa/wpa/MRSS/newreleases/sf=143441/<%= parameters %>/rss.xml";
				case Rss.FeedType.JustAdded:
					return @"https://itunes.apple.com/WebObjects/MZStore.woa/wpa/MRSS/justadded/sf=143441/<%= parameters %>/rss.xml";
				case Rss.FeedType.FeaturedAlbums:
					return @"https://itunes.apple.com/WebObjects/MZStore.woa/wpa/MRSS/featuredalbums/sf=143441/<%= parameters %>/rss.xml";
				case Rss.FeedType.TopMacApps:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topmacapps/<%= parameters %>/xml";
				case Rss.FeedType.TopFreeMacApps:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topfreemacapps/<%= parameters %>/xml";
				case Rss.FeedType.TopGrossingMacApps:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topgrossingmacapps/<%= parameters %>/xml";
				case Rss.FeedType.TopPaidMacApps:
					return @"https://itunes.apple.com/<%= country_code %>/rss/toppaidmacapps/<%= parameters %>/xml";
				case Rss.FeedType.TopPodcasts:
					return @"https://itunes.apple.com/<%= country_code %>/rss/toppodcasts/<%= parameters %>/xml";
				case Rss.FeedType.TopPaidBooks:
					return @"https://itunes.apple.com/<%= country_code %>/rss/toppaidebooks/<%= parameters %>/xml";
				case Rss.FeedType.TopFreeBooks:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topfreeebooks/<%= parameters %>/xml";
				case Rss.FeedType.TopTextbooks:
					return @"https://itunes.apple.com/<%= country_code %>/rss/toptextbooks/<%= parameters %>/xml";
				case Rss.FeedType.TopItunesUCollections:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topitunesucollections/<%= parameters %>/xml";
				case Rss.FeedType.TopItunesUCourses:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topitunesucourses/<%= parameters %>/xml";
				case Rss.FeedType.TopTvEpisodes:
					return @"https://itunes.apple.com/<%= country_code %>/rss/toptvepisodes/<%= parameters %>/xml";
				case Rss.FeedType.TopTvSeasons:
					return @"https://itunes.apple.com/<%= country_code %>/rss/toptvseasons/<%= parameters %>/xml";
				case Rss.FeedType.TopMusicVideos:
					return @"https://itunes.apple.com/<%= country_code %>/rss/topmusicvideos/<%= parameters %>/xml";
			}
			throw new NotImplementedException();
		}
		public static String GetGenreId(this Rss.FeedType feedType, Rss.Genre genre) {
			var feedTypeGenres = new [] {
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopAudiobooks,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.ArtsAndEntertainment, Id = @"50000041" },
						new { Genre = Rss.Genre.AudiobooksLatino, Id = @"50000070" },
						new { Genre = Rss.Genre.BiographyAndMemoir, Id = @"50000042" },
						new { Genre = Rss.Genre.Business, Id = @"50000043" },
						new { Genre = Rss.Genre.Classics, Id = @"50000045" },
						new { Genre = Rss.Genre.Comedy, Id = @"50000046" },
						new { Genre = Rss.Genre.DramaAndPoetry, Id = @"50000047" },
						new { Genre = Rss.Genre.Fiction, Id = @"50000040" },
						new { Genre = Rss.Genre.History, Id = @"50000049" },
						new { Genre = Rss.Genre.KidsAndYoungAdults, Id = @"50000044" },
						new { Genre = Rss.Genre.Languages, Id = @"50000050" },
						new { Genre = Rss.Genre.Mystery, Id = @"50000051" },
						new { Genre = Rss.Genre.News, Id = @"74" },
						new { Genre = Rss.Genre.Nonfiction, Id = @"50000052" },
						new { Genre = Rss.Genre.ReligionAndSpirituality, Id = @"50000053" },
						new { Genre = Rss.Genre.Romance, Id = @"50000069" },
						new { Genre = Rss.Genre.SciFiAndFantasy, Id = @"50000055" },
						new { Genre = Rss.Genre.Science, Id = @"50000054" },
						new { Genre = Rss.Genre.SelfDevelopment, Id = @"50000056" },
						new { Genre = Rss.Genre.ProgramsAndPerformances, Id = @"75" },
						new { Genre = Rss.Genre.SpeakersAndStorytellers, Id = @"50000048" },
						new { Genre = Rss.Genre.Sports, Id = @"50000057" },
						new { Genre = Rss.Genre.Technology, Id = @"50000058" },
						new { Genre = Rss.Genre.TravelAndAdventure, Id = @"50000059" },
					}
				},
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopFreeApplications,
						Rss.FeedType.TopPaidApplications,
						Rss.FeedType.TopGrossingApplications,
						Rss.FeedType.TopFreeIpadApplications,
						Rss.FeedType.TopPaidIpadApplications,
						Rss.FeedType.TopGrossingIpadApplications,
						Rss.FeedType.NewApplications,
						Rss.FeedType.NewFreeApplications,
						Rss.FeedType.NewPaidApplications,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.Books, Id = @"6018" },
						new { Genre = Rss.Genre.Business, Id = @"6000" },
						new { Genre = Rss.Genre.Catalogs, Id = @"6022" },
						new { Genre = Rss.Genre.Education, Id = @"6017" },
						new { Genre = Rss.Genre.Entertainment, Id = @"6016" },
						new { Genre = Rss.Genre.Finance, Id = @"6015" },
						new { Genre = Rss.Genre.FoodAndDrink, Id = @"6023" },
						new { Genre = Rss.Genre.Games, Id = @"6014" },
						new { Genre = Rss.Genre.HealthAndFitness, Id = @"6013" },
						new { Genre = Rss.Genre.Lifestyle, Id = @"6012" },
						new { Genre = Rss.Genre.Medical, Id = @"6020" },
						new { Genre = Rss.Genre.Music, Id = @"6011" },
						new { Genre = Rss.Genre.Navigation, Id = @"6010" },
						new { Genre = Rss.Genre.News, Id = @"6009" },
						new { Genre = Rss.Genre.Newsstand, Id = @"6021" },
						new { Genre = Rss.Genre.PhotoAndVideo, Id = @"6008" },
						new { Genre = Rss.Genre.Productivity, Id = @"6007" },
						new { Genre = Rss.Genre.Reference, Id = @"6006" },
						new { Genre = Rss.Genre.SocialNetworking, Id = @"6005" },
						new { Genre = Rss.Genre.Sports, Id = @"6004" },
						new { Genre = Rss.Genre.Travel, Id = @"6003" },
						new { Genre = Rss.Genre.Utilities, Id = @"6002" },
						new { Genre = Rss.Genre.Weather, Id = @"6001" },
					}
				},
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopMovies,
						Rss.FeedType.TopVideoRentals,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.ActionAndAdventure, Id = @"4401" },
						new { Genre = Rss.Genre.African, Id = @"4434" },
						new { Genre = Rss.Genre.Anime, Id = @"4402" },
						new { Genre = Rss.Genre.Bollywood, Id = @"4431" },
						new { Genre = Rss.Genre.Classics, Id = @"4403" },
						new { Genre = Rss.Genre.Comedy, Id = @"4404" },
						new { Genre = Rss.Genre.ConcertFilms, Id = @"4422" },
						new { Genre = Rss.Genre.Documentary, Id = @"4405" },
						new { Genre = Rss.Genre.Drama, Id = @"4406" },
						new { Genre = Rss.Genre.Foreign, Id = @"4407" },
						new { Genre = Rss.Genre.Holiday, Id = @"4420" },
						new { Genre = Rss.Genre.Horror, Id = @"4408" },
						new { Genre = Rss.Genre.Independent, Id = @"4409" },
						new { Genre = Rss.Genre.JapaneseCinema, Id = @"4425" },
						new { Genre = Rss.Genre.Jidaigeki, Id = @"4426" },
						new { Genre = Rss.Genre.KidsAndFamily, Id = @"4410" },
						new { Genre = Rss.Genre.KoreanCinema, Id = @"4428" },
						new { Genre = Rss.Genre.MadeForTv, Id = @"4421" },
						new { Genre = Rss.Genre.Middleeastern, Id = @"4433" },
						new { Genre = Rss.Genre.MusicDocumentaries, Id = @"4423" },
						new { Genre = Rss.Genre.MusicFeatureFilms, Id = @"4424" },
						new { Genre = Rss.Genre.Musicals, Id = @"4411" },
						new { Genre = Rss.Genre.RegionalIndian, Id = @"4432" },
						new { Genre = Rss.Genre.Romance, Id = @"4412" },
						new { Genre = Rss.Genre.Russian, Id = @"4429" },
						new { Genre = Rss.Genre.ScifiAndFantasy, Id = @"4413" },
						new { Genre = Rss.Genre.ShortFilms, Id = @"4414" },
						new { Genre = Rss.Genre.SpecialInterest, Id = @"4415" },
						new { Genre = Rss.Genre.Sports, Id = @"4417" },
						new { Genre = Rss.Genre.Thriller, Id = @"4416" },
						new { Genre = Rss.Genre.Tokusatsu, Id = @"4427" },
						new { Genre = Rss.Genre.Turkish, Id = @"4430" },
						new { Genre = Rss.Genre.Urban, Id = @"4419" },
						new { Genre = Rss.Genre.Western, Id = @"4418" },
					}
				},
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopAlbums,
						Rss.FeedType.TopImixes,
						Rss.FeedType.TopSongs,
						Rss.FeedType.NewReleases,
						Rss.FeedType.JustAdded,
						Rss.FeedType.FeaturedAlbums,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.Alternative, Id = @"20" },
						new { Genre = Rss.Genre.Anime, Id = @"29" },
						new { Genre = Rss.Genre.Blues, Id = @"2" },
						new { Genre = Rss.Genre.Brazilian, Id = @"1122" },
						new { Genre = Rss.Genre.ChildrensMusic, Id = @"4" },
						new { Genre = Rss.Genre.Chinese, Id = @"1232" },
						new { Genre = Rss.Genre.ChristianAndGospel, Id = @"22" },
						new { Genre = Rss.Genre.Classical, Id = @"5" },
						new { Genre = Rss.Genre.Comedy, Id = @"3" },
						new { Genre = Rss.Genre.Country, Id = @"6" },
						new { Genre = Rss.Genre.Dance, Id = @"17" },
						new { Genre = Rss.Genre.Disney, Id = @"50000063" },
						new { Genre = Rss.Genre.EasyListening, Id = @"25" },
						new { Genre = Rss.Genre.Electronic, Id = @"7" },
						new { Genre = Rss.Genre.Enka, Id = @"28" },
						new { Genre = Rss.Genre.FitnessAndWorkout, Id = @"50" },
						new { Genre = Rss.Genre.FrenchPop, Id = @"50000064" },
						new { Genre = Rss.Genre.GermanFolk, Id = @"50000068" },
						new { Genre = Rss.Genre.GermanPop, Id = @"50000066" },
						new { Genre = Rss.Genre.HiphopRap, Id = @"18" },
						new { Genre = Rss.Genre.Holiday, Id = @"8" },
						new { Genre = Rss.Genre.Indian, Id = @"1262" },
						new { Genre = Rss.Genre.Instrumental, Id = @"53" },
						new { Genre = Rss.Genre.Jpop, Id = @"27" },
						new { Genre = Rss.Genre.Jazz, Id = @"11" },
						new { Genre = Rss.Genre.Kpop, Id = @"51" },
						new { Genre = Rss.Genre.Karaoke, Id = @"52" },
						new { Genre = Rss.Genre.Kayokyoku, Id = @"30" },
						new { Genre = Rss.Genre.Korean, Id = @"1243" },
						new { Genre = Rss.Genre.Latino, Id = @"12" },
						new { Genre = Rss.Genre.NewAge, Id = @"13" },
						new { Genre = Rss.Genre.Opera, Id = @"9" },
						new { Genre = Rss.Genre.Pop, Id = @"14" },
						new { Genre = Rss.Genre.RAndBSoul, Id = @"15" },
						new { Genre = Rss.Genre.Reggae, Id = @"24" },
						new { Genre = Rss.Genre.Rock, Id = @"21" },
						new { Genre = Rss.Genre.SingerSongwriter, Id = @"10" },
						new { Genre = Rss.Genre.Soundtrack, Id = @"16" },
						new { Genre = Rss.Genre.SpokenWord, Id = @"50000061" },
						new { Genre = Rss.Genre.Vocal, Id = @"23" },
						new { Genre = Rss.Genre.World, Id = @"19" },
					}
				},
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopMacApps,
						Rss.FeedType.TopFreeMacApps,
						Rss.FeedType.TopGrossingMacApps,
						Rss.FeedType.TopPaidMacApps,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.Business, Id = @"12001" },
						new { Genre = Rss.Genre.DeveloperTools, Id = @"12002" },
						new { Genre = Rss.Genre.Education, Id = @"12003" },
						new { Genre = Rss.Genre.Entertainment, Id = @"12004" },
						new { Genre = Rss.Genre.Finance, Id = @"12005" },
						new { Genre = Rss.Genre.Games, Id = @"12006" },
						new { Genre = Rss.Genre.GraphicsAndDesign, Id = @"12022" },
						new { Genre = Rss.Genre.HealthAndFitness, Id = @"12007" },
						new { Genre = Rss.Genre.Lifestyle, Id = @"12008" },
						new { Genre = Rss.Genre.Medical, Id = @"12010" },
						new { Genre = Rss.Genre.Music, Id = @"12011" },
						new { Genre = Rss.Genre.News, Id = @"12012" },
						new { Genre = Rss.Genre.Photography, Id = @"12013" },
						new { Genre = Rss.Genre.Productivity, Id = @"12014" },
						new { Genre = Rss.Genre.Reference, Id = @"12015" },
						new { Genre = Rss.Genre.SocialNetworking, Id = @"12016" },
						new { Genre = Rss.Genre.Sports, Id = @"12017" },
						new { Genre = Rss.Genre.Travel, Id = @"12018" },
						new { Genre = Rss.Genre.Utilities, Id = @"12019" },
						new { Genre = Rss.Genre.Video, Id = @"12020" },
						new { Genre = Rss.Genre.Weather, Id = @"12021" },
					}
				},
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopPodcasts,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.Arts, Id = @"1301" },
						new { Genre = Rss.Genre.Business, Id = @"1321" },
						new { Genre = Rss.Genre.Comedy, Id = @"1303" },
						new { Genre = Rss.Genre.Education, Id = @"1304" },
						new { Genre = Rss.Genre.GamesAndHobbies, Id = @"1323" },
						new { Genre = Rss.Genre.GovernmentAndOrganizations, Id = @"1325" },
						new { Genre = Rss.Genre.Health, Id = @"1307" },
						new { Genre = Rss.Genre.KidsAndFamily, Id = @"1305" },
						new { Genre = Rss.Genre.Music, Id = @"1310" },
						new { Genre = Rss.Genre.NewsAndPolitics, Id = @"1311" },
						new { Genre = Rss.Genre.ReligionAndSpirituality, Id = @"1314" },
						new { Genre = Rss.Genre.ScienceAndMedicine, Id = @"1315" },
						new { Genre = Rss.Genre.SocietyAndCulture, Id = @"1324" },
						new { Genre = Rss.Genre.SportsAndRecreation, Id = @"1316" },
						new { Genre = Rss.Genre.TvAndFilm, Id = @"1309" },
						new { Genre = Rss.Genre.Technology, Id = @"1318" },
					}
				},
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopPaidBooks,
						Rss.FeedType.TopFreeBooks,
						Rss.FeedType.TopTextbooks,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.ArtsAndEntertainment, Id = @"9007" },
						new { Genre = Rss.Genre.BiographiesAndMemoirs, Id = @"9008" },
						new { Genre = Rss.Genre.BusinessAndPersonalFinance, Id = @"9009" },
						new { Genre = Rss.Genre.ChildrenAndTeens, Id = @"9010" },
						new { Genre = Rss.Genre.ComicsAndGraphicNovels, Id = @"9026" },
						new { Genre = Rss.Genre.ComputersAndInternet, Id = @"9027" },
						new { Genre = Rss.Genre.CookbooksFoodAndWine, Id = @"9028" },
						new { Genre = Rss.Genre.FictionAndLiterature, Id = @"9031" },
						new { Genre = Rss.Genre.HealthMindAndBody, Id = @"9025" },
						new { Genre = Rss.Genre.History, Id = @"9015" },
						new { Genre = Rss.Genre.Humor, Id = @"9012" },
						new { Genre = Rss.Genre.LifestyleAndHome, Id = @"9024" },
						new { Genre = Rss.Genre.MysteriesAndThrillers, Id = @"9032" },
						new { Genre = Rss.Genre.Nonfiction, Id = @"9002" },
						new { Genre = Rss.Genre.Parenting, Id = @"9030" },
						new { Genre = Rss.Genre.PoliticsAndCurrentEvents, Id = @"9034" },
						new { Genre = Rss.Genre.ProfessionalAndTechnical, Id = @"9029" },
						new { Genre = Rss.Genre.Reference, Id = @"9033" },
						new { Genre = Rss.Genre.ReligionAndSpirituality, Id = @"9018" },
						new { Genre = Rss.Genre.Romance, Id = @"9003" },
						new { Genre = Rss.Genre.ScifiAndFantasy, Id = @"9020" },
						new { Genre = Rss.Genre.ScienceAndNature, Id = @"9019" },
						new { Genre = Rss.Genre.SportsAndOutdoors, Id = @"9035" },
						new { Genre = Rss.Genre.TravelAndAdventure, Id = @"9004" },
					}
				},
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopItunesUCollections,
						Rss.FeedType.TopItunesUCourses,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.ArtAndArchitecture, Id = @"40000016" },
						new { Genre = Rss.Genre.Business, Id = @"40000001" },
						new { Genre = Rss.Genre.CommunicationsAndMedia, Id = @"40000053" },
						new { Genre = Rss.Genre.Engineering, Id = @"40000009" },
						new { Genre = Rss.Genre.HealthAndMedicine, Id = @"40000026" },
						new { Genre = Rss.Genre.History, Id = @"40000041" },
						new { Genre = Rss.Genre.Language, Id = @"40000056" },
						new { Genre = Rss.Genre.LawAndPolitics, Id = @"40000140" },
						new { Genre = Rss.Genre.Literature, Id = @"40000070" },
						new { Genre = Rss.Genre.Mathematics, Id = @"40000077" },
						new { Genre = Rss.Genre.Philosophy, Id = @"40000054" },
						new { Genre = Rss.Genre.PsychologyAndSocialScience, Id = @"40000094" },
						new { Genre = Rss.Genre.ReligionAndSpirituality, Id = @"40000055" },
						new { Genre = Rss.Genre.Science, Id = @"40000084" },
						new { Genre = Rss.Genre.Society, Id = @"40000101" },
						new { Genre = Rss.Genre.TeachingAndLearning, Id = @"40000109" },
					}
				},
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopTvEpisodes,
						Rss.FeedType.TopTvSeasons,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.ActionAndAdventure, Id = @"4003" },
						new { Genre = Rss.Genre.Animation, Id = @"4002" },
						new { Genre = Rss.Genre.Classic, Id = @"4004" },
						new { Genre = Rss.Genre.Comedy, Id = @"4000" },
						new { Genre = Rss.Genre.Drama, Id = @"4001" },
						new { Genre = Rss.Genre.Kids, Id = @"4005" },
						new { Genre = Rss.Genre.LatinoTv, Id = @"4011" },
						new { Genre = Rss.Genre.Nonfiction, Id = @"4006" },
						new { Genre = Rss.Genre.RealityTv, Id = @"4007" },
						new { Genre = Rss.Genre.ScifiAndFantasy, Id = @"4008" },
						new { Genre = Rss.Genre.Sports, Id = @"4009" },
						new { Genre = Rss.Genre.Teens, Id = @"4010" },
					}
				},
				new {
					FeedTypes = new Rss.FeedType [] {
						Rss.FeedType.TopMusicVideos,
					},
					Genres = new [] {
						new { Genre = Rss.Genre.All, Id = @"" },
						new { Genre = Rss.Genre.Alternative, Id = @"1620" },
						new { Genre = Rss.Genre.Anime, Id = @"1629" },
						new { Genre = Rss.Genre.BigBand, Id = @"1685" },
						new { Genre = Rss.Genre.Blues, Id = @"1602" },
						new { Genre = Rss.Genre.Brazilian, Id = @"1671" },
						new { Genre = Rss.Genre.ChildrensMusic, Id = @"1604" },
						new { Genre = Rss.Genre.Chinese, Id = @"1637" },
						new { Genre = Rss.Genre.ChristianAndGospel, Id = @"1622" },
						new { Genre = Rss.Genre.Classical, Id = @"1605" },
						new { Genre = Rss.Genre.Comedy, Id = @"1603" },
						new { Genre = Rss.Genre.Country, Id = @"1606" },
						new { Genre = Rss.Genre.Dance, Id = @"1617" },
						new { Genre = Rss.Genre.Disney, Id = @"1631" },
						new { Genre = Rss.Genre.EasyListening, Id = @"1625" },
						new { Genre = Rss.Genre.Electronic, Id = @"1607" },
						new { Genre = Rss.Genre.Enka, Id = @"1628" },
						new { Genre = Rss.Genre.FitnessAndWorkout, Id = @"1683" },
						new { Genre = Rss.Genre.FrenchPop, Id = @"1632" },
						new { Genre = Rss.Genre.GermanFolk, Id = @"1634" },
						new { Genre = Rss.Genre.GermanPop, Id = @"1633" },
						new { Genre = Rss.Genre.HiphopRap, Id = @"1618" },
						new { Genre = Rss.Genre.Holiday, Id = @"1608" },
						new { Genre = Rss.Genre.Indian, Id = @"1690" },
						new { Genre = Rss.Genre.Instrumental, Id = @"1684" },
						new { Genre = Rss.Genre.Jpop, Id = @"1627" },
						new { Genre = Rss.Genre.Jazz, Id = @"1611" },
						new { Genre = Rss.Genre.Kpop, Id = @"1686" },
						new { Genre = Rss.Genre.Karaoke, Id = @"1687" },
						new { Genre = Rss.Genre.Kayokyoku, Id = @"1630" },
						new { Genre = Rss.Genre.Korean, Id = @"1648" },
						new { Genre = Rss.Genre.Latin, Id = @"1612" },
						new { Genre = Rss.Genre.NewAge, Id = @"1613" },
						new { Genre = Rss.Genre.Opera, Id = @"1609" },
						new { Genre = Rss.Genre.Podcasts, Id = @"1626" },
						new { Genre = Rss.Genre.Pop, Id = @"1614" },
						new { Genre = Rss.Genre.RAndBSoul, Id = @"1615" },
						new { Genre = Rss.Genre.Reggae, Id = @"1624" },
						new { Genre = Rss.Genre.Rock, Id = @"1621" },
						new { Genre = Rss.Genre.SingerSongwriter, Id = @"1610" },
						new { Genre = Rss.Genre.Soundtrack, Id = @"1616" },
						new { Genre = Rss.Genre.SpokenWord, Id = @"1689" },
						new { Genre = Rss.Genre.Vocal, Id = @"1623" },
						new { Genre = Rss.Genre.World, Id = @"1619" },
					}
				},
			};
			return feedTypeGenres.Single(x => x.FeedTypes.Contains(feedType)).Genres.Single(x => x.Genre == genre).Id;
		}
	}
}