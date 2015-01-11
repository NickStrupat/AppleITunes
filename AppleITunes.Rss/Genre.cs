using System.ComponentModel;

namespace AppleITunes {
	public enum Genre {
		[Description("Action & Adventure")]
        ActionAndAdventure,
		[Description("African")]
        African,
		[Description("All")]
        All,
		[Description("Alternative")]
        Alternative,
		[Description("Animation")]
        Animation,
		[Description("Anime")]
        Anime,
		[Description("Art & Architecture")]
        ArtAndArchitecture,
		[Description("Arts")]
        Arts,
		[Description("Arts & Entertainment")]
        ArtsAndEntertainment,
		[Description("Audiobooks Latino")]
        AudiobooksLatino,
		[Description("Big Band")]
        BigBand,
		[Description("Biographies & Memoirs")]
        BiographiesAndMemoirs,
		[Description("Biography & Memoir")]
        BiographyAndMemoir,
		[Description("Blues")]
        Blues,
		[Description("Bollywood")]
        Bollywood,
		[Description("Books")]
        Books,
		[Description("Brazilian")]
        Brazilian,
		[Description("Business")]
        Business,
		[Description("Business & Personal Finance")]
        BusinessAndPersonalFinance,
		[Description("Catalogs")]
        Catalogs,
		[Description("Children & Teens")]
        ChildrenAndTeens,
		[Description("Children's Music")]
        ChildrensMusic,
		[Description("Chinese")]
        Chinese,
		[Description("Christian & Gospel")]
        ChristianAndGospel,
		[Description("Classic")]
        Classic,
		[Description("Classical")]
        Classical,
		[Description("Classics")]
        Classics,
		[Description("Comedy")]
        Comedy,
		[Description("Comics & Graphic Novels")]
        ComicsAndGraphicNovels,
		[Description("Communications & Media")]
        CommunicationsAndMedia,
		[Description("Computers & Internet")]
        ComputersAndInternet,
		[Description("Concert Films")]
        ConcertFilms,
		[Description("Cookbooks, Food & Wine")]
        CookbooksFoodAndWine,
		[Description("Country")]
        Country,
		[Description("Dance")]
        Dance,
		[Description("Developer Tools")]
        DeveloperTools,
		[Description("Disney")]
        Disney,
		[Description("Documentary")]
        Documentary,
		[Description("Drama")]
        Drama,
		[Description("Drama & Poetry")]
        DramaAndPoetry,
		[Description("Easy Listening")]
        EasyListening,
		[Description("Education")]
        Education,
		[Description("Electronic")]
        Electronic,
		[Description("Engineering")]
        Engineering,
		[Description("Enka")]
        Enka,
		[Description("Entertainment")]
        Entertainment,
		[Description("Fiction")]
        Fiction,
		[Description("Fiction & Literature")]
        FictionAndLiterature,
		[Description("Finance")]
        Finance,
		[Description("Fitness & Workout")]
        FitnessAndWorkout,
		[Description("Food & Drink")]
        FoodAndDrink,
		[Description("Foreign")]
        Foreign,
		[Description("French Pop")]
        FrenchPop,
		[Description("Games")]
        Games,
		[Description("Games & Hobbies")]
        GamesAndHobbies,
		[Description("German Folk")]
        GermanFolk,
		[Description("German Pop")]
        GermanPop,
		[Description("Government & Organizations")]
        GovernmentAndOrganizations,
		[Description("Graphics & Design")]
        GraphicsAndDesign,
		[Description("Health")]
        Health,
		[Description("Health & Fitness")]
        HealthAndFitness,
		[Description("Health & Medicine")]
        HealthAndMedicine,
		[Description("Health, Mind & Body")]
        HealthMindAndBody,
		[Description("Hip-Hop/Rap")]
        HiphopRap,
		[Description("History")]
        History,
		[Description("Holiday")]
        Holiday,
		[Description("Horror")]
        Horror,
		[Description("Humor")]
        Humor,
		[Description("Independent")]
        Independent,
		[Description("Indian")]
        Indian,
		[Description("Instrumental")]
        Instrumental,
		[Description("Japanese Cinema")]
        JapaneseCinema,
		[Description("Jazz")]
        Jazz,
		[Description("Jidaigeki")]
        Jidaigeki,
		[Description("J-Pop")]
        Jpop,
		[Description("Karaoke")]
        Karaoke,
		[Description("Kayokyoku")]
        Kayokyoku,
		[Description("Kids")]
        Kids,
		[Description("Kids & Family")]
        KidsAndFamily,
		[Description("Kids & Young Adults")]
        KidsAndYoungAdults,
		[Description("Korean")]
        Korean,
		[Description("Korean Cinema")]
        KoreanCinema,
		[Description("K-Pop")]
        Kpop,
		[Description("Language")]
        Language,
		[Description("Languages")]
        Languages,
		[Description("Latin")]
        Latin,
		[Description("Latino")]
        Latino,
		[Description("Latino TV")]
        LatinoTv,
		[Description("Law & Politics")]
        LawAndPolitics,
		[Description("Lifestyle")]
        Lifestyle,
		[Description("Lifestyle & Home")]
        LifestyleAndHome,
		[Description("Literature")]
        Literature,
		[Description("Made for TV")]
        MadeForTv,
		[Description("Mathematics")]
        Mathematics,
		[Description("Medical")]
        Medical,
		[Description("MiddleEastern")]
        Middleeastern,
		[Description("Music")]
        Music,
		[Description("Musicals")]
        Musicals,
		[Description("Music Documentaries")]
        MusicDocumentaries,
		[Description("Music Feature Films")]
        MusicFeatureFilms,
		[Description("Mysteries & Thrillers")]
        MysteriesAndThrillers,
		[Description("Mystery")]
        Mystery,
		[Description("Navigation")]
        Navigation,
		[Description("New Age")]
        NewAge,
		[Description("News")]
        News,
		[Description("News & Politics")]
        NewsAndPolitics,
		[Description("Newsstand")]
        Newsstand,
		[Description("Nonfiction")]
        Nonfiction,
		[Description("Opera")]
        Opera,
		[Description("Parenting")]
        Parenting,
		[Description("Philosophy")]
        Philosophy,
		[Description("Photo & Video")]
        PhotoAndVideo,
		[Description("Photography")]
        Photography,
		[Description("Podcasts")]
        Podcasts,
		[Description("Politics & Current Events")]
        PoliticsAndCurrentEvents,
		[Description("Pop")]
        Pop,
		[Description("Productivity")]
        Productivity,
		[Description("Professional & Technical")]
        ProfessionalAndTechnical,
		[Description("Programs & Performances")]
        ProgramsAndPerformances,
		[Description("Psychology & Social Science")]
        PsychologyAndSocialScience,
		[Description("R&B/Soul")]
        RAndBSoul,
		[Description("Reality TV")]
        RealityTv,
		[Description("Reference")]
        Reference,
		[Description("Reggae")]
        Reggae,
		[Description("Regional Indian")]
        RegionalIndian,
		[Description("Religion & Spirituality")]
        ReligionAndSpirituality,
		[Description("Rock")]
        Rock,
		[Description("Romance")]
        Romance,
		[Description("Russian")]
        Russian,
		[Description("Science")]
        Science,
		[Description("Science & Medicine")]
        ScienceAndMedicine,
		[Description("Science & Nature")]
        ScienceAndNature,
		[Description("Sci-Fi & Fantasy")]
        ScifiAndFantasy,
		[Description("Sci Fi & Fantasy")]
        SciFiAndFantasy,
		[Description("Self Development")]
        SelfDevelopment,
		[Description("Short Films")]
        ShortFilms,
		[Description("Singer/Songwriter")]
        SingerSongwriter,
		[Description("Social Networking")]
        SocialNetworking,
		[Description("Society")]
        Society,
		[Description("Society & Culture")]
        SocietyAndCulture,
		[Description("Soundtrack")]
        Soundtrack,
		[Description("Speakers & Storytellers")]
        SpeakersAndStorytellers,
		[Description("Special Interest")]
        SpecialInterest,
		[Description("Spoken Word")]
        SpokenWord,
		[Description("Sports")]
        Sports,
		[Description("Sports & Outdoors")]
        SportsAndOutdoors,
		[Description("Sports & Recreation")]
        SportsAndRecreation,
		[Description("Teaching & Learning")]
        TeachingAndLearning,
		[Description("Technology")]
        Technology,
		[Description("Teens")]
        Teens,
		[Description("Thriller")]
        Thriller,
		[Description("Tokusatsu")]
        Tokusatsu,
		[Description("Travel")]
        Travel,
		[Description("Travel & Adventure")]
        TravelAndAdventure,
		[Description("Turkish")]
        Turkish,
		[Description("TV & Film")]
        TvAndFilm,
		[Description("Urban")]
        Urban,
		[Description("Utilities")]
        Utilities,
		[Description("Video")]
        Video,
		[Description("Vocal")]
        Vocal,
		[Description("Weather")]
        Weather,
		[Description("Western")]
        Western,
		[Description("World")]
        World,
	}
}