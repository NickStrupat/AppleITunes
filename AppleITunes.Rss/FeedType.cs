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

		internal static class FeedTypeExtensions {
			public static String GetUrlPattern(this FeedType feedType) {
				switch (feedType) {
					case FeedType.TopAudiobooks:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topaudiobooks/<%= parameters %>/xml";
					case FeedType.TopFreeApplications:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topfreeapplications/<%= parameters %>/xml";
					case FeedType.TopPaidApplications:
						return @"https://itunes.apple.com/<%= country_code %>/rss/toppaidapplications/<%= parameters %>/xml";
					case FeedType.TopGrossingApplications:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topgrossingapplications/<%= parameters %>/xml";
					case FeedType.TopFreeIpadApplications:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topfreeipadapplications/<%= parameters %>/xml";
					case FeedType.TopPaidIpadApplications:
						return @"https://itunes.apple.com/<%= country_code %>/rss/toppaidipadapplications/<%= parameters %>/xml";
					case FeedType.TopGrossingIpadApplications:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topgrossingipadapplications/<%= parameters %>/xml";
					case FeedType.NewApplications:
						return @"https://itunes.apple.com/<%= country_code %>/rss/newapplications/<%= parameters %>/xml";
					case FeedType.NewFreeApplications:
						return @"https://itunes.apple.com/<%= country_code %>/rss/newfreeapplications/<%= parameters %>/xml";
					case FeedType.NewPaidApplications:
						return @"https://itunes.apple.com/<%= country_code %>/rss/newpaidapplications/<%= parameters %>/xml";
					case FeedType.TopMovies:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topmovies/<%= parameters %>/xml";
					case FeedType.TopVideoRentals:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topvideorentals/<%= parameters %>/xml";
					case FeedType.TopAlbums:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topalbums/<%= parameters %>/xml";
					case FeedType.TopImixes:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topimixes/<%= parameters %>/xml";
					case FeedType.TopSongs:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topsongs/<%= parameters %>/xml";
					case FeedType.NewReleases:
						return @"https://itunes.apple.com/WebObjects/MZStore.woa/wpa/MRSS/newreleases/sf=143441/<%= parameters %>/rss.xml";
					case FeedType.JustAdded:
						return @"https://itunes.apple.com/WebObjects/MZStore.woa/wpa/MRSS/justadded/sf=143441/<%= parameters %>/rss.xml";
					case FeedType.FeaturedAlbums:
						return @"https://itunes.apple.com/WebObjects/MZStore.woa/wpa/MRSS/featuredalbums/sf=143441/<%= parameters %>/rss.xml";
					case FeedType.TopMacApps:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topmacapps/<%= parameters %>/xml";
					case FeedType.TopFreeMacApps:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topfreemacapps/<%= parameters %>/xml";
					case FeedType.TopGrossingMacApps:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topgrossingmacapps/<%= parameters %>/xml";
					case FeedType.TopPaidMacApps:
						return @"https://itunes.apple.com/<%= country_code %>/rss/toppaidmacapps/<%= parameters %>/xml";
					case FeedType.TopPodcasts:
						return @"https://itunes.apple.com/<%= country_code %>/rss/toppodcasts/<%= parameters %>/xml";
					case FeedType.TopPaidBooks:
						return @"https://itunes.apple.com/<%= country_code %>/rss/toppaidebooks/<%= parameters %>/xml";
					case FeedType.TopFreeBooks:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topfreeebooks/<%= parameters %>/xml";
					case FeedType.TopTextbooks:
						return @"https://itunes.apple.com/<%= country_code %>/rss/toptextbooks/<%= parameters %>/xml";
					case FeedType.TopItunesUCollections:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topitunesucollections/<%= parameters %>/xml";
					case FeedType.TopItunesUCourses:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topitunesucourses/<%= parameters %>/xml";
					case FeedType.TopTvEpisodes:
						return @"https://itunes.apple.com/<%= country_code %>/rss/toptvepisodes/<%= parameters %>/xml";
					case FeedType.TopTvSeasons:
						return @"https://itunes.apple.com/<%= country_code %>/rss/toptvseasons/<%= parameters %>/xml";
					case FeedType.TopMusicVideos:
						return @"https://itunes.apple.com/<%= country_code %>/rss/topmusicvideos/<%= parameters %>/xml";
				}
				throw new NotImplementedException();
			}
			public static String GetGenreId(this FeedType feedType, Genre genre) {
				var feedTypeGenres = new [] {
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopAudiobooks,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.ArtsAndEntertainment, Id = @"50000041" },
							new { Genre = Genre.AudiobooksLatino, Id = @"50000070" },
							new { Genre = Genre.BiographyAndMemoir, Id = @"50000042" },
							new { Genre = Genre.Business, Id = @"50000043" },
							new { Genre = Genre.Classics, Id = @"50000045" },
							new { Genre = Genre.Comedy, Id = @"50000046" },
							new { Genre = Genre.DramaAndPoetry, Id = @"50000047" },
							new { Genre = Genre.Fiction, Id = @"50000040" },
							new { Genre = Genre.History, Id = @"50000049" },
							new { Genre = Genre.KidsAndYoungAdults, Id = @"50000044" },
							new { Genre = Genre.Languages, Id = @"50000050" },
							new { Genre = Genre.Mystery, Id = @"50000051" },
							new { Genre = Genre.News, Id = @"74" },
							new { Genre = Genre.Nonfiction, Id = @"50000052" },
							new { Genre = Genre.ReligionAndSpirituality, Id = @"50000053" },
							new { Genre = Genre.Romance, Id = @"50000069" },
							new { Genre = Genre.SciFiAndFantasy, Id = @"50000055" },
							new { Genre = Genre.Science, Id = @"50000054" },
							new { Genre = Genre.SelfDevelopment, Id = @"50000056" },
							new { Genre = Genre.ProgramsAndPerformances, Id = @"75" },
							new { Genre = Genre.SpeakersAndStorytellers, Id = @"50000048" },
							new { Genre = Genre.Sports, Id = @"50000057" },
							new { Genre = Genre.Technology, Id = @"50000058" },
							new { Genre = Genre.TravelAndAdventure, Id = @"50000059" },
						}
					},
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopFreeApplications,
							FeedType.TopPaidApplications,
							FeedType.TopGrossingApplications,
							FeedType.TopFreeIpadApplications,
							FeedType.TopPaidIpadApplications,
							FeedType.TopGrossingIpadApplications,
							FeedType.NewApplications,
							FeedType.NewFreeApplications,
							FeedType.NewPaidApplications,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.Books, Id = @"6018" },
							new { Genre = Genre.Business, Id = @"6000" },
							new { Genre = Genre.Catalogs, Id = @"6022" },
							new { Genre = Genre.Education, Id = @"6017" },
							new { Genre = Genre.Entertainment, Id = @"6016" },
							new { Genre = Genre.Finance, Id = @"6015" },
							new { Genre = Genre.FoodAndDrink, Id = @"6023" },
							new { Genre = Genre.Games, Id = @"6014" },
							new { Genre = Genre.HealthAndFitness, Id = @"6013" },
							new { Genre = Genre.Lifestyle, Id = @"6012" },
							new { Genre = Genre.Medical, Id = @"6020" },
							new { Genre = Genre.Music, Id = @"6011" },
							new { Genre = Genre.Navigation, Id = @"6010" },
							new { Genre = Genre.News, Id = @"6009" },
							new { Genre = Genre.Newsstand, Id = @"6021" },
							new { Genre = Genre.PhotoAndVideo, Id = @"6008" },
							new { Genre = Genre.Productivity, Id = @"6007" },
							new { Genre = Genre.Reference, Id = @"6006" },
							new { Genre = Genre.SocialNetworking, Id = @"6005" },
							new { Genre = Genre.Sports, Id = @"6004" },
							new { Genre = Genre.Travel, Id = @"6003" },
							new { Genre = Genre.Utilities, Id = @"6002" },
							new { Genre = Genre.Weather, Id = @"6001" },
						}
					},
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopMovies,
							FeedType.TopVideoRentals,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.ActionAndAdventure, Id = @"4401" },
							new { Genre = Genre.African, Id = @"4434" },
							new { Genre = Genre.Anime, Id = @"4402" },
							new { Genre = Genre.Bollywood, Id = @"4431" },
							new { Genre = Genre.Classics, Id = @"4403" },
							new { Genre = Genre.Comedy, Id = @"4404" },
							new { Genre = Genre.ConcertFilms, Id = @"4422" },
							new { Genre = Genre.Documentary, Id = @"4405" },
							new { Genre = Genre.Drama, Id = @"4406" },
							new { Genre = Genre.Foreign, Id = @"4407" },
							new { Genre = Genre.Holiday, Id = @"4420" },
							new { Genre = Genre.Horror, Id = @"4408" },
							new { Genre = Genre.Independent, Id = @"4409" },
							new { Genre = Genre.JapaneseCinema, Id = @"4425" },
							new { Genre = Genre.Jidaigeki, Id = @"4426" },
							new { Genre = Genre.KidsAndFamily, Id = @"4410" },
							new { Genre = Genre.KoreanCinema, Id = @"4428" },
							new { Genre = Genre.MadeForTv, Id = @"4421" },
							new { Genre = Genre.Middleeastern, Id = @"4433" },
							new { Genre = Genre.MusicDocumentaries, Id = @"4423" },
							new { Genre = Genre.MusicFeatureFilms, Id = @"4424" },
							new { Genre = Genre.Musicals, Id = @"4411" },
							new { Genre = Genre.RegionalIndian, Id = @"4432" },
							new { Genre = Genre.Romance, Id = @"4412" },
							new { Genre = Genre.Russian, Id = @"4429" },
							new { Genre = Genre.ScifiAndFantasy, Id = @"4413" },
							new { Genre = Genre.ShortFilms, Id = @"4414" },
							new { Genre = Genre.SpecialInterest, Id = @"4415" },
							new { Genre = Genre.Sports, Id = @"4417" },
							new { Genre = Genre.Thriller, Id = @"4416" },
							new { Genre = Genre.Tokusatsu, Id = @"4427" },
							new { Genre = Genre.Turkish, Id = @"4430" },
							new { Genre = Genre.Urban, Id = @"4419" },
							new { Genre = Genre.Western, Id = @"4418" },
						}
					},
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopAlbums,
							FeedType.TopImixes,
							FeedType.TopSongs,
							FeedType.NewReleases,
							FeedType.JustAdded,
							FeedType.FeaturedAlbums,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.Alternative, Id = @"20" },
							new { Genre = Genre.Anime, Id = @"29" },
							new { Genre = Genre.Blues, Id = @"2" },
							new { Genre = Genre.Brazilian, Id = @"1122" },
							new { Genre = Genre.ChildrensMusic, Id = @"4" },
							new { Genre = Genre.Chinese, Id = @"1232" },
							new { Genre = Genre.ChristianAndGospel, Id = @"22" },
							new { Genre = Genre.Classical, Id = @"5" },
							new { Genre = Genre.Comedy, Id = @"3" },
							new { Genre = Genre.Country, Id = @"6" },
							new { Genre = Genre.Dance, Id = @"17" },
							new { Genre = Genre.Disney, Id = @"50000063" },
							new { Genre = Genre.EasyListening, Id = @"25" },
							new { Genre = Genre.Electronic, Id = @"7" },
							new { Genre = Genre.Enka, Id = @"28" },
							new { Genre = Genre.FitnessAndWorkout, Id = @"50" },
							new { Genre = Genre.FrenchPop, Id = @"50000064" },
							new { Genre = Genre.GermanFolk, Id = @"50000068" },
							new { Genre = Genre.GermanPop, Id = @"50000066" },
							new { Genre = Genre.HiphopRap, Id = @"18" },
							new { Genre = Genre.Holiday, Id = @"8" },
							new { Genre = Genre.Indian, Id = @"1262" },
							new { Genre = Genre.Instrumental, Id = @"53" },
							new { Genre = Genre.Jpop, Id = @"27" },
							new { Genre = Genre.Jazz, Id = @"11" },
							new { Genre = Genre.Kpop, Id = @"51" },
							new { Genre = Genre.Karaoke, Id = @"52" },
							new { Genre = Genre.Kayokyoku, Id = @"30" },
							new { Genre = Genre.Korean, Id = @"1243" },
							new { Genre = Genre.Latino, Id = @"12" },
							new { Genre = Genre.NewAge, Id = @"13" },
							new { Genre = Genre.Opera, Id = @"9" },
							new { Genre = Genre.Pop, Id = @"14" },
							new { Genre = Genre.RAndBSoul, Id = @"15" },
							new { Genre = Genre.Reggae, Id = @"24" },
							new { Genre = Genre.Rock, Id = @"21" },
							new { Genre = Genre.SingerSongwriter, Id = @"10" },
							new { Genre = Genre.Soundtrack, Id = @"16" },
							new { Genre = Genre.SpokenWord, Id = @"50000061" },
							new { Genre = Genre.Vocal, Id = @"23" },
							new { Genre = Genre.World, Id = @"19" },
						}
					},
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopMacApps,
							FeedType.TopFreeMacApps,
							FeedType.TopGrossingMacApps,
							FeedType.TopPaidMacApps,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.Business, Id = @"12001" },
							new { Genre = Genre.DeveloperTools, Id = @"12002" },
							new { Genre = Genre.Education, Id = @"12003" },
							new { Genre = Genre.Entertainment, Id = @"12004" },
							new { Genre = Genre.Finance, Id = @"12005" },
							new { Genre = Genre.Games, Id = @"12006" },
							new { Genre = Genre.GraphicsAndDesign, Id = @"12022" },
							new { Genre = Genre.HealthAndFitness, Id = @"12007" },
							new { Genre = Genre.Lifestyle, Id = @"12008" },
							new { Genre = Genre.Medical, Id = @"12010" },
							new { Genre = Genre.Music, Id = @"12011" },
							new { Genre = Genre.News, Id = @"12012" },
							new { Genre = Genre.Photography, Id = @"12013" },
							new { Genre = Genre.Productivity, Id = @"12014" },
							new { Genre = Genre.Reference, Id = @"12015" },
							new { Genre = Genre.SocialNetworking, Id = @"12016" },
							new { Genre = Genre.Sports, Id = @"12017" },
							new { Genre = Genre.Travel, Id = @"12018" },
							new { Genre = Genre.Utilities, Id = @"12019" },
							new { Genre = Genre.Video, Id = @"12020" },
							new { Genre = Genre.Weather, Id = @"12021" },
						}
					},
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopPodcasts,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.Arts, Id = @"1301" },
							new { Genre = Genre.Business, Id = @"1321" },
							new { Genre = Genre.Comedy, Id = @"1303" },
							new { Genre = Genre.Education, Id = @"1304" },
							new { Genre = Genre.GamesAndHobbies, Id = @"1323" },
							new { Genre = Genre.GovernmentAndOrganizations, Id = @"1325" },
							new { Genre = Genre.Health, Id = @"1307" },
							new { Genre = Genre.KidsAndFamily, Id = @"1305" },
							new { Genre = Genre.Music, Id = @"1310" },
							new { Genre = Genre.NewsAndPolitics, Id = @"1311" },
							new { Genre = Genre.ReligionAndSpirituality, Id = @"1314" },
							new { Genre = Genre.ScienceAndMedicine, Id = @"1315" },
							new { Genre = Genre.SocietyAndCulture, Id = @"1324" },
							new { Genre = Genre.SportsAndRecreation, Id = @"1316" },
							new { Genre = Genre.TvAndFilm, Id = @"1309" },
							new { Genre = Genre.Technology, Id = @"1318" },
						}
					},
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopPaidBooks,
							FeedType.TopFreeBooks,
							FeedType.TopTextbooks,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.ArtsAndEntertainment, Id = @"9007" },
							new { Genre = Genre.BiographiesAndMemoirs, Id = @"9008" },
							new { Genre = Genre.BusinessAndPersonalFinance, Id = @"9009" },
							new { Genre = Genre.ChildrenAndTeens, Id = @"9010" },
							new { Genre = Genre.ComicsAndGraphicNovels, Id = @"9026" },
							new { Genre = Genre.ComputersAndInternet, Id = @"9027" },
							new { Genre = Genre.CookbooksFoodAndWine, Id = @"9028" },
							new { Genre = Genre.FictionAndLiterature, Id = @"9031" },
							new { Genre = Genre.HealthMindAndBody, Id = @"9025" },
							new { Genre = Genre.History, Id = @"9015" },
							new { Genre = Genre.Humor, Id = @"9012" },
							new { Genre = Genre.LifestyleAndHome, Id = @"9024" },
							new { Genre = Genre.MysteriesAndThrillers, Id = @"9032" },
							new { Genre = Genre.Nonfiction, Id = @"9002" },
							new { Genre = Genre.Parenting, Id = @"9030" },
							new { Genre = Genre.PoliticsAndCurrentEvents, Id = @"9034" },
							new { Genre = Genre.ProfessionalAndTechnical, Id = @"9029" },
							new { Genre = Genre.Reference, Id = @"9033" },
							new { Genre = Genre.ReligionAndSpirituality, Id = @"9018" },
							new { Genre = Genre.Romance, Id = @"9003" },
							new { Genre = Genre.ScifiAndFantasy, Id = @"9020" },
							new { Genre = Genre.ScienceAndNature, Id = @"9019" },
							new { Genre = Genre.SportsAndOutdoors, Id = @"9035" },
							new { Genre = Genre.TravelAndAdventure, Id = @"9004" },
						}
					},
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopItunesUCollections,
							FeedType.TopItunesUCourses,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.ArtAndArchitecture, Id = @"40000016" },
							new { Genre = Genre.Business, Id = @"40000001" },
							new { Genre = Genre.CommunicationsAndMedia, Id = @"40000053" },
							new { Genre = Genre.Engineering, Id = @"40000009" },
							new { Genre = Genre.HealthAndMedicine, Id = @"40000026" },
							new { Genre = Genre.History, Id = @"40000041" },
							new { Genre = Genre.Language, Id = @"40000056" },
							new { Genre = Genre.LawAndPolitics, Id = @"40000140" },
							new { Genre = Genre.Literature, Id = @"40000070" },
							new { Genre = Genre.Mathematics, Id = @"40000077" },
							new { Genre = Genre.Philosophy, Id = @"40000054" },
							new { Genre = Genre.PsychologyAndSocialScience, Id = @"40000094" },
							new { Genre = Genre.ReligionAndSpirituality, Id = @"40000055" },
							new { Genre = Genre.Science, Id = @"40000084" },
							new { Genre = Genre.Society, Id = @"40000101" },
							new { Genre = Genre.TeachingAndLearning, Id = @"40000109" },
						}
					},
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopTvEpisodes,
							FeedType.TopTvSeasons,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.ActionAndAdventure, Id = @"4003" },
							new { Genre = Genre.Animation, Id = @"4002" },
							new { Genre = Genre.Classic, Id = @"4004" },
							new { Genre = Genre.Comedy, Id = @"4000" },
							new { Genre = Genre.Drama, Id = @"4001" },
							new { Genre = Genre.Kids, Id = @"4005" },
							new { Genre = Genre.LatinoTv, Id = @"4011" },
							new { Genre = Genre.Nonfiction, Id = @"4006" },
							new { Genre = Genre.RealityTv, Id = @"4007" },
							new { Genre = Genre.ScifiAndFantasy, Id = @"4008" },
							new { Genre = Genre.Sports, Id = @"4009" },
							new { Genre = Genre.Teens, Id = @"4010" },
						}
					},
					new {
						FeedTypes = new FeedType [] {
							FeedType.TopMusicVideos,
						},
						Genres = new [] {
							new { Genre = Genre.All, Id = @"" },
							new { Genre = Genre.Alternative, Id = @"1620" },
							new { Genre = Genre.Anime, Id = @"1629" },
							new { Genre = Genre.BigBand, Id = @"1685" },
							new { Genre = Genre.Blues, Id = @"1602" },
							new { Genre = Genre.Brazilian, Id = @"1671" },
							new { Genre = Genre.ChildrensMusic, Id = @"1604" },
							new { Genre = Genre.Chinese, Id = @"1637" },
							new { Genre = Genre.ChristianAndGospel, Id = @"1622" },
							new { Genre = Genre.Classical, Id = @"1605" },
							new { Genre = Genre.Comedy, Id = @"1603" },
							new { Genre = Genre.Country, Id = @"1606" },
							new { Genre = Genre.Dance, Id = @"1617" },
							new { Genre = Genre.Disney, Id = @"1631" },
							new { Genre = Genre.EasyListening, Id = @"1625" },
							new { Genre = Genre.Electronic, Id = @"1607" },
							new { Genre = Genre.Enka, Id = @"1628" },
							new { Genre = Genre.FitnessAndWorkout, Id = @"1683" },
							new { Genre = Genre.FrenchPop, Id = @"1632" },
							new { Genre = Genre.GermanFolk, Id = @"1634" },
							new { Genre = Genre.GermanPop, Id = @"1633" },
							new { Genre = Genre.HiphopRap, Id = @"1618" },
							new { Genre = Genre.Holiday, Id = @"1608" },
							new { Genre = Genre.Indian, Id = @"1690" },
							new { Genre = Genre.Instrumental, Id = @"1684" },
							new { Genre = Genre.Jpop, Id = @"1627" },
							new { Genre = Genre.Jazz, Id = @"1611" },
							new { Genre = Genre.Kpop, Id = @"1686" },
							new { Genre = Genre.Karaoke, Id = @"1687" },
							new { Genre = Genre.Kayokyoku, Id = @"1630" },
							new { Genre = Genre.Korean, Id = @"1648" },
							new { Genre = Genre.Latin, Id = @"1612" },
							new { Genre = Genre.NewAge, Id = @"1613" },
							new { Genre = Genre.Opera, Id = @"1609" },
							new { Genre = Genre.Podcasts, Id = @"1626" },
							new { Genre = Genre.Pop, Id = @"1614" },
							new { Genre = Genre.RAndBSoul, Id = @"1615" },
							new { Genre = Genre.Reggae, Id = @"1624" },
							new { Genre = Genre.Rock, Id = @"1621" },
							new { Genre = Genre.SingerSongwriter, Id = @"1610" },
							new { Genre = Genre.Soundtrack, Id = @"1616" },
							new { Genre = Genre.SpokenWord, Id = @"1689" },
							new { Genre = Genre.Vocal, Id = @"1623" },
							new { Genre = Genre.World, Id = @"1619" },
						}
					},
				};
				return feedTypeGenres.Single(x => x.FeedTypes.Contains(feedType)).Genres.Single(x => x.Genre == genre).Id;
			}
		}
	}
}