using System;
using System.ComponentModel;

namespace AppleITunes {
	public static partial class Rss {
		public enum Country {
			[Description("Albania")]
			Albania,
			[Description("Czech Republic")]
			CzechRepublic,
			[Description("Ukraine")]
			Ukraine,
			[Description("Algeria")]
			Algeria,
			[Description("Angola")]
			Angola,
			[Description("Anguilla")]
			Anguilla,
			[Description("Antigua and Barbuda")]
			AntiguaAndBarbuda,
			[Description("Argentina")]
			Argentina,
			[Description("Argentina (English)")]
			ArgentinaEnglish,
			[Description("Armenia")]
			Armenia,
			[Description("Australia")]
			Australia,
			[Description("Azerbaijan")]
			Azerbaijan,
			[Description("Bahamas")]
			Bahamas,
			[Description("Bahrain")]
			Bahrain,
			[Description("Barbados")]
			Barbados,
			[Description("Belarus")]
			Belarus,
			[Description("Belgium")]
			Belgium,
			[Description("Belgium (English)")]
			BelgiumEnglish,
			[Description("Belgium (French)")]
			BelgiumFrench,
			[Description("Belize")]
			Belize,
			[Description("Belize (Spanish)")]
			BelizeSpanish,
			[Description("Benin")]
			Benin,
			[Description("Bermuda")]
			Bermuda,
			[Description("Bhutan")]
			Bhutan,
			[Description("Bolivia")]
			Bolivia,
			[Description("Bolivia (English)")]
			BoliviaEnglish,
			[Description("Botswana")]
			Botswana,
			[Description("Brazil")]
			Brazil,
			[Description("Brazil (English)")]
			BrazilEnglish,
			[Description("Brunei Darussalam")]
			BruneiDarussalam,
			[Description("Burkina Faso")]
			BurkinaFaso,
			[Description("Cambodia")]
			Cambodia,
			[Description("Canada")]
			Canada,
			[Description("Canada (French)")]
			CanadaFrench,
			[Description("Cape Verde")]
			CapeVerde,
			[Description("Cayman Islands")]
			CaymanIslands,
			[Description("Chad")]
			Chad,
			[Description("Chile")]
			Chile,
			[Description("Chile (English)")]
			ChileEnglish,
			[Description("Colombia")]
			Colombia,
			[Description("Colombia (English)")]
			ColombiaEnglish,
			[Description("Congo, Republic of the")]
			CongoRepublicOfThe,
			[Description("Costa Rica")]
			CostaRica,
			[Description("Costa Rica (English)")]
			CostaRicaEnglish,
			[Description("Cyprus")]
			Cyprus,
			[Description("Denmark")]
			Denmark,
			[Description("Denmark (English)")]
			DenmarkEnglish,
			[Description("Germany")]
			Germany,
			[Description("Germany (English)")]
			GermanyEnglish,
			[Description("Dominica")]
			Dominica,
			[Description("Dominica (English)")]
			DominicaEnglish,
			[Description("Ecuador")]
			Ecuador,
			[Description("Ecuador (English)")]
			EcuadorEnglish,
			[Description("Estonia")]
			Estonia,
			[Description("Egypt")]
			Egypt,
			[Description("El Salvador")]
			ElSalvador,
			[Description("El Salvador (English)")]
			ElSalvadorEnglish,
			[Description("Spain")]
			Spain,
			[Description("Spain (English)")]
			SpainEnglish,
			[Description("Fiji")]
			Fiji,
			[Description("France")]
			France,
			[Description("France (English)")]
			FranceEnglish,
			[Description("Gambia")]
			Gambia,
			[Description("Ghana")]
			Ghana,
			[Description("Greece")]
			Greece,
			[Description("Grenada")]
			Grenada,
			[Description("Guatemala")]
			Guatemala,
			[Description("Guatemala (English)")]
			GuatemalaEnglish,
			[Description("Guinea-Bissau")]
			Guineabissau,
			[Description("Guyana")]
			Guyana,
			[Description("Honduras")]
			Honduras,
			[Description("Honduras (English)")]
			HondurasEnglish,
			[Description("Hong Kong")]
			HongKong,
			[Description("Hong Kong (English)")]
			HongKongEnglish,
			[Description("Croatia")]
			Croatia,
			[Description("Iceland")]
			Iceland,
			[Description("India")]
			India,
			[Description("Indonesia")]
			Indonesia,
			[Description("Indonesia (English)")]
			IndonesiaEnglish,
			[Description("Ireland")]
			Ireland,
			[Description("Israel")]
			Israel,
			[Description("Italy")]
			Italy,
			[Description("Italy (English)")]
			ItalyEnglish,
			[Description("Jamaica")]
			Jamaica,
			[Description("Jordan")]
			Jordan,
			[Description("Kazakhstan")]
			Kazakhstan,
			[Description("Kenya")]
			Kenya,
			[Description("Kuwait")]
			Kuwait,
			[Description("Kyrgyzstan")]
			Kyrgyzstan,
			[Description("Lao, People's Democratic Republic")]
			LaoPeoplesDemocraticRepublic,
			[Description("Latvia")]
			Latvia,
			[Description("Lebanon")]
			Lebanon,
			[Description("Liberia")]
			Liberia,
			[Description("Lithuania")]
			Lithuania,
			[Description("Luxembourg")]
			Luxembourg,
			[Description("Luxembourg (French)")]
			LuxembourgFrench,
			[Description("Luxembourg (English)")]
			LuxembourgEnglish,
			[Description("Macau")]
			Macau,
			[Description("Macau (English)")]
			MacauEnglish,
			[Description("Macedonia")]
			Macedonia,
			[Description("Madagascar")]
			Madagascar,
			[Description("Hungary")]
			Hungary,
			[Description("Malawi")]
			Malawi,
			[Description("Malaysia")]
			Malaysia,
			[Description("Malaysia (English)")]
			MalaysiaEnglish,
			[Description("Mali")]
			Mali,
			[Description("Malta")]
			Malta,
			[Description("Mauritania")]
			Mauritania,
			[Description("Mauritius")]
			Mauritius,
			[Description("Mexico")]
			Mexico,
			[Description("Mexico (English)")]
			MexicoEnglish,
			[Description("Micronesia, Federated States of")]
			MicronesiaFederatedStatesOf,
			[Description("Moldova")]
			Moldova,
			[Description("Mongolia")]
			Mongolia,
			[Description("Montserrat")]
			Montserrat,
			[Description("Mozambique")]
			Mozambique,
			[Description("Namibia")]
			Namibia,
			[Description("Netherlands")]
			Netherlands,
			[Description("Netherlands (English)")]
			NetherlandsEnglish,
			[Description("Nepal")]
			Nepal,
			[Description("New Zealand")]
			NewZealand,
			[Description("Nicaragua")]
			Nicaragua,
			[Description("Nicaragua (English)")]
			NicaraguaEnglish,
			[Description("Niger")]
			Niger,
			[Description("Nigeria")]
			Nigeria,
			[Description("Norway")]
			Norway,
			[Description("Norway (English)")]
			NorwayEnglish,
			[Description("Oman")]
			Oman,
			[Description("Austria")]
			Austria,
			[Description("Austria (English)")]
			AustriaEnglish,
			[Description("Pakistan")]
			Pakistan,
			[Description("Palau")]
			Palau,
			[Description("Panama")]
			Panama,
			[Description("Panama (English)")]
			PanamaEnglish,
			[Description("Papua New Guinea")]
			PapuaNewGuinea,
			[Description("Paraguay")]
			Paraguay,
			[Description("Paraguay (English)")]
			ParaguayEnglish,
			[Description("Peru")]
			Peru,
			[Description("Philippines")]
			Philippines,
			[Description("Poland")]
			Poland,
			[Description("Portugal")]
			Portugal,
			[Description("Portugal (English)")]
			PortugalEnglish,
			[Description("Dominican Republic")]
			DominicanRepublic,
			[Description("Dominican Republic (English)")]
			DominicanRepublicEnglish,
			[Description("Romania")]
			Romania,
			[Description("St. Kitts and Nevis")]
			StKittsAndNevis,
			[Description("St. Lucia")]
			StLucia,
			[Description("St. Vincent and The Grenadines")]
			StVincentAndTheGrenadines,
			[Description("Saudi Arabia")]
			SaudiArabia,
			[Description("São Tomé and Príncipe")]
			SãoToméAndPríncipe,
			[Description("Switzerland")]
			Switzerland,
			[Description("Switzerland (French)")]
			SwitzerlandFrench,
			[Description("Switzerland (English)")]
			SwitzerlandEnglish,
			[Description("Switzerland (Italian)")]
			SwitzerlandItalian,
			[Description("Senegal")]
			Senegal,
			[Description("Seychelles")]
			Seychelles,
			[Description("Sierra Leone")]
			SierraLeone,
			[Description("Singapore")]
			Singapore,
			[Description("Singapore (English)")]
			SingaporeEnglish,
			[Description("Slovakia")]
			Slovakia,
			[Description("Slovenia")]
			Slovenia,
			[Description("Solomon Islands")]
			SolomonIslands,
			[Description("South Africa")]
			SouthAfrica,
			[Description("Sri Lanka")]
			SriLanka,
			[Description("Finland")]
			Finland,
			[Description("Finland (English)")]
			FinlandEnglish,
			[Description("Suriname")]
			Suriname,
			[Description("Suriname (English)")]
			SurinameEnglish,
			[Description("Sweden")]
			Sweden,
			[Description("Sweden (English)")]
			SwedenEnglish,
			[Description("Swaziland")]
			Swaziland,
			[Description("Tajikistan")]
			Tajikistan,
			[Description("Tanzania")]
			Tanzania,
			[Description("Thailand")]
			Thailand,
			[Description("Thailand (English)")]
			ThailandEnglish,
			[Description("Trinidad and Tobago")]
			TrinidadAndTobago,
			[Description("Tunisia")]
			Tunisia,
			[Description("Turkmenistan")]
			Turkmenistan,
			[Description("Turks and Caicos")]
			TurksAndCaicos,
			[Description("Turkey")]
			Turkey,
			[Description("Turkey (English)")]
			TurkeyEnglish,
			[Description("United Kingdom")]
			UnitedKingdom,
			[Description("United States")]
			UnitedStates,
			[Description("United States (Spanish)")]
			UnitedStatesSpanish,
			[Description("Uganda")]
			Uganda,
			[Description("Qatar")]
			Qatar,
			[Description("United Arab Emirates")]
			UnitedArabEmirates,
			[Description("Uruguay")]
			Uruguay,
			[Description("Uruguay (English)")]
			UruguayEnglish,
			[Description("Uzbekistan")]
			Uzbekistan,
			[Description("Venezuela")]
			Venezuela,
			[Description("Venezuela (English)")]
			VenezuelaEnglish,
			[Description("Vietnam")]
			Vietnam,
			[Description("Vietnam (English)")]
			VietnamEnglish,
			[Description("British Virgin Islands")]
			BritishVirginIslands,
			[Description("Yemen")]
			Yemen,
			[Description("Zimbabwe")]
			Zimbabwe,
			[Description("Bulgaria")]
			Bulgaria,
			[Description("Russia")]
			Russia,
			[Description("Russia (English)")]
			RussiaEnglish,
			[Description("Korea, Republic Of")]
			KoreaRepublicOf,
			[Description("Korea, Republic Of (English)")]
			KoreaRepublicOfEnglish,
			[Description("China")]
			China,
			[Description("China (English)")]
			ChinaEnglish,
			[Description("Taiwan")]
			Taiwan,
			[Description("Taiwan (English)")]
			TaiwanEnglish,
			[Description("Japan")]
			Japan,
			[Description("Japan (English)")]
			JapanEnglish,
		}
	}

	internal static class CountryExtensions {
		public static String GetCode(this Rss.Country country) {
			switch (country) {
				case Rss.Country.Albania:
					return @"al";
				case Rss.Country.CzechRepublic:
					return @"cz";
				case Rss.Country.Ukraine:
					return @"ua";
				case Rss.Country.Algeria:
					return @"dz";
				case Rss.Country.Angola:
					return @"ao";
				case Rss.Country.Anguilla:
					return @"ai";
				case Rss.Country.AntiguaAndBarbuda:
					return @"ag";
				case Rss.Country.Argentina:
					return @"ar";
				case Rss.Country.ArgentinaEnglish:
					return @"ar_en";
				case Rss.Country.Armenia:
					return @"am";
				case Rss.Country.Australia:
					return @"au";
				case Rss.Country.Azerbaijan:
					return @"az";
				case Rss.Country.Bahamas:
					return @"bs";
				case Rss.Country.Bahrain:
					return @"bh";
				case Rss.Country.Barbados:
					return @"bb";
				case Rss.Country.Belarus:
					return @"by";
				case Rss.Country.Belgium:
					return @"be";
				case Rss.Country.BelgiumEnglish:
					return @"be_en";
				case Rss.Country.BelgiumFrench:
					return @"be_fr";
				case Rss.Country.Belize:
					return @"bz";
				case Rss.Country.BelizeSpanish:
					return @"bz_es";
				case Rss.Country.Benin:
					return @"bj";
				case Rss.Country.Bermuda:
					return @"bm";
				case Rss.Country.Bhutan:
					return @"bt";
				case Rss.Country.Bolivia:
					return @"bo";
				case Rss.Country.BoliviaEnglish:
					return @"bo_en";
				case Rss.Country.Botswana:
					return @"bw";
				case Rss.Country.Brazil:
					return @"br";
				case Rss.Country.BrazilEnglish:
					return @"br_en";
				case Rss.Country.BruneiDarussalam:
					return @"bn";
				case Rss.Country.BurkinaFaso:
					return @"bf";
				case Rss.Country.Cambodia:
					return @"kh";
				case Rss.Country.Canada:
					return @"ca";
				case Rss.Country.CanadaFrench:
					return @"ca_fr";
				case Rss.Country.CapeVerde:
					return @"cv";
				case Rss.Country.CaymanIslands:
					return @"ky";
				case Rss.Country.Chad:
					return @"td";
				case Rss.Country.Chile:
					return @"cl";
				case Rss.Country.ChileEnglish:
					return @"cl_en";
				case Rss.Country.Colombia:
					return @"co";
				case Rss.Country.ColombiaEnglish:
					return @"co_en";
				case Rss.Country.CongoRepublicOfThe:
					return @"cg";
				case Rss.Country.CostaRica:
					return @"cr";
				case Rss.Country.CostaRicaEnglish:
					return @"cr_en";
				case Rss.Country.Cyprus:
					return @"cy";
				case Rss.Country.Denmark:
					return @"dk";
				case Rss.Country.DenmarkEnglish:
					return @"dk_en";
				case Rss.Country.Germany:
					return @"de";
				case Rss.Country.GermanyEnglish:
					return @"de_en";
				case Rss.Country.Dominica:
					return @"dm";
				case Rss.Country.DominicaEnglish:
					return @"dm_en";
				case Rss.Country.Ecuador:
					return @"ec";
				case Rss.Country.EcuadorEnglish:
					return @"ec_en";
				case Rss.Country.Estonia:
					return @"ee";
				case Rss.Country.Egypt:
					return @"eg";
				case Rss.Country.ElSalvador:
					return @"sv";
				case Rss.Country.ElSalvadorEnglish:
					return @"sv_en";
				case Rss.Country.Spain:
					return @"es";
				case Rss.Country.SpainEnglish:
					return @"es_en";
				case Rss.Country.Fiji:
					return @"fj";
				case Rss.Country.France:
					return @"fr";
				case Rss.Country.FranceEnglish:
					return @"fr_en";
				case Rss.Country.Gambia:
					return @"gm";
				case Rss.Country.Ghana:
					return @"gh";
				case Rss.Country.Greece:
					return @"gr";
				case Rss.Country.Grenada:
					return @"gd";
				case Rss.Country.Guatemala:
					return @"gt";
				case Rss.Country.GuatemalaEnglish:
					return @"gt_en";
				case Rss.Country.Guineabissau:
					return @"gw";
				case Rss.Country.Guyana:
					return @"gy";
				case Rss.Country.Honduras:
					return @"hn";
				case Rss.Country.HondurasEnglish:
					return @"hn_en";
				case Rss.Country.HongKong:
					return @"hk";
				case Rss.Country.HongKongEnglish:
					return @"hk_en";
				case Rss.Country.Croatia:
					return @"hr";
				case Rss.Country.Iceland:
					return @"is";
				case Rss.Country.India:
					return @"in";
				case Rss.Country.Indonesia:
					return @"id";
				case Rss.Country.IndonesiaEnglish:
					return @"id_en";
				case Rss.Country.Ireland:
					return @"ie";
				case Rss.Country.Israel:
					return @"il";
				case Rss.Country.Italy:
					return @"it";
				case Rss.Country.ItalyEnglish:
					return @"it_en";
				case Rss.Country.Jamaica:
					return @"jm";
				case Rss.Country.Jordan:
					return @"jo";
				case Rss.Country.Kazakhstan:
					return @"kz";
				case Rss.Country.Kenya:
					return @"ke";
				case Rss.Country.Kuwait:
					return @"kw";
				case Rss.Country.Kyrgyzstan:
					return @"kg";
				case Rss.Country.LaoPeoplesDemocraticRepublic:
					return @"la";
				case Rss.Country.Latvia:
					return @"lv";
				case Rss.Country.Lebanon:
					return @"lb";
				case Rss.Country.Liberia:
					return @"lr";
				case Rss.Country.Lithuania:
					return @"lt";
				case Rss.Country.Luxembourg:
					return @"lu";
				case Rss.Country.LuxembourgFrench:
					return @"lu_fr";
				case Rss.Country.LuxembourgEnglish:
					return @"lu_en";
				case Rss.Country.Macau:
					return @"mo";
				case Rss.Country.MacauEnglish:
					return @"mo_en";
				case Rss.Country.Macedonia:
					return @"mk";
				case Rss.Country.Madagascar:
					return @"mg";
				case Rss.Country.Hungary:
					return @"hu";
				case Rss.Country.Malawi:
					return @"mw";
				case Rss.Country.Malaysia:
					return @"my";
				case Rss.Country.MalaysiaEnglish:
					return @"my_en";
				case Rss.Country.Mali:
					return @"ml";
				case Rss.Country.Malta:
					return @"mt";
				case Rss.Country.Mauritania:
					return @"mr";
				case Rss.Country.Mauritius:
					return @"mu";
				case Rss.Country.Mexico:
					return @"mx";
				case Rss.Country.MexicoEnglish:
					return @"mx_en";
				case Rss.Country.MicronesiaFederatedStatesOf:
					return @"fm";
				case Rss.Country.Moldova:
					return @"md";
				case Rss.Country.Mongolia:
					return @"mn";
				case Rss.Country.Montserrat:
					return @"ms";
				case Rss.Country.Mozambique:
					return @"mz";
				case Rss.Country.Namibia:
					return @"na";
				case Rss.Country.Netherlands:
					return @"nl";
				case Rss.Country.NetherlandsEnglish:
					return @"nl_en";
				case Rss.Country.Nepal:
					return @"np";
				case Rss.Country.NewZealand:
					return @"nz";
				case Rss.Country.Nicaragua:
					return @"ni";
				case Rss.Country.NicaraguaEnglish:
					return @"ni_en";
				case Rss.Country.Niger:
					return @"ne";
				case Rss.Country.Nigeria:
					return @"ng";
				case Rss.Country.Norway:
					return @"no";
				case Rss.Country.NorwayEnglish:
					return @"no_en";
				case Rss.Country.Oman:
					return @"om";
				case Rss.Country.Austria:
					return @"at";
				case Rss.Country.AustriaEnglish:
					return @"at_en";
				case Rss.Country.Pakistan:
					return @"pk";
				case Rss.Country.Palau:
					return @"pw";
				case Rss.Country.Panama:
					return @"pa";
				case Rss.Country.PanamaEnglish:
					return @"pa_en";
				case Rss.Country.PapuaNewGuinea:
					return @"pg";
				case Rss.Country.Paraguay:
					return @"py";
				case Rss.Country.ParaguayEnglish:
					return @"py_en";
				case Rss.Country.Peru:
					return @"pe";
				case Rss.Country.Philippines:
					return @"ph";
				case Rss.Country.Poland:
					return @"pl";
				case Rss.Country.Portugal:
					return @"pt";
				case Rss.Country.PortugalEnglish:
					return @"pt_en";
				case Rss.Country.DominicanRepublic:
					return @"do";
				case Rss.Country.DominicanRepublicEnglish:
					return @"do_en";
				case Rss.Country.Romania:
					return @"ro";
				case Rss.Country.StKittsAndNevis:
					return @"kn";
				case Rss.Country.StLucia:
					return @"lc";
				case Rss.Country.StVincentAndTheGrenadines:
					return @"vc";
				case Rss.Country.SaudiArabia:
					return @"sa";
				case Rss.Country.SãoToméAndPríncipe:
					return @"st";
				case Rss.Country.Switzerland:
					return @"ch";
				case Rss.Country.SwitzerlandFrench:
					return @"ch_fr";
				case Rss.Country.SwitzerlandEnglish:
					return @"ch_en";
				case Rss.Country.SwitzerlandItalian:
					return @"ch_it";
				case Rss.Country.Senegal:
					return @"sn";
				case Rss.Country.Seychelles:
					return @"sc";
				case Rss.Country.SierraLeone:
					return @"sl";
				case Rss.Country.Singapore:
					return @"sg";
				case Rss.Country.SingaporeEnglish:
					return @"sg_en";
				case Rss.Country.Slovakia:
					return @"sk";
				case Rss.Country.Slovenia:
					return @"si";
				case Rss.Country.SolomonIslands:
					return @"sb";
				case Rss.Country.SouthAfrica:
					return @"za";
				case Rss.Country.SriLanka:
					return @"lk";
				case Rss.Country.Finland:
					return @"fi";
				case Rss.Country.FinlandEnglish:
					return @"fi_en";
				case Rss.Country.Suriname:
					return @"sr";
				case Rss.Country.SurinameEnglish:
					return @"sr_en";
				case Rss.Country.Sweden:
					return @"se";
				case Rss.Country.SwedenEnglish:
					return @"se_en";
				case Rss.Country.Swaziland:
					return @"sz";
				case Rss.Country.Tajikistan:
					return @"tj";
				case Rss.Country.Tanzania:
					return @"tz";
				case Rss.Country.Thailand:
					return @"th";
				case Rss.Country.ThailandEnglish:
					return @"th_en";
				case Rss.Country.TrinidadAndTobago:
					return @"tt";
				case Rss.Country.Tunisia:
					return @"tn";
				case Rss.Country.Turkmenistan:
					return @"tm";
				case Rss.Country.TurksAndCaicos:
					return @"tc";
				case Rss.Country.Turkey:
					return @"tr";
				case Rss.Country.TurkeyEnglish:
					return @"tr_en";
				case Rss.Country.UnitedKingdom:
					return @"gb";
				case Rss.Country.UnitedStates:
					return @"us";
				case Rss.Country.UnitedStatesSpanish:
					return @"us_es";
				case Rss.Country.Uganda:
					return @"ug";
				case Rss.Country.Qatar:
					return @"qa";
				case Rss.Country.UnitedArabEmirates:
					return @"ae";
				case Rss.Country.Uruguay:
					return @"uy";
				case Rss.Country.UruguayEnglish:
					return @"uy_en";
				case Rss.Country.Uzbekistan:
					return @"uz";
				case Rss.Country.Venezuela:
					return @"ve";
				case Rss.Country.VenezuelaEnglish:
					return @"ve_en";
				case Rss.Country.Vietnam:
					return @"vn";
				case Rss.Country.VietnamEnglish:
					return @"vn_en";
				case Rss.Country.BritishVirginIslands:
					return @"vg";
				case Rss.Country.Yemen:
					return @"ye";
				case Rss.Country.Zimbabwe:
					return @"zw";
				case Rss.Country.Bulgaria:
					return @"bg";
				case Rss.Country.Russia:
					return @"ru";
				case Rss.Country.RussiaEnglish:
					return @"ru_en";
				case Rss.Country.KoreaRepublicOf:
					return @"kr";
				case Rss.Country.KoreaRepublicOfEnglish:
					return @"kr_en";
				case Rss.Country.China:
					return @"cn";
				case Rss.Country.ChinaEnglish:
					return @"cn_en";
				case Rss.Country.Taiwan:
					return @"tw";
				case Rss.Country.TaiwanEnglish:
					return @"tw_en";
				case Rss.Country.Japan:
					return @"jp";
				case Rss.Country.JapanEnglish:
					return @"jp_en";
			}
			throw new NotImplementedException();
		}
	}
}