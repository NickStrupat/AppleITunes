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
			Argentina(english),
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
			Belgium(english),
			[Description("Belgium (French)")]
			Belgium(french),
			[Description("Belize")]
			Belize,
			[Description("Belize (Spanish)")]
			Belize(spanish),
			[Description("Benin")]
			Benin,
			[Description("Bermuda")]
			Bermuda,
			[Description("Bhutan")]
			Bhutan,
			[Description("Bolivia")]
			Bolivia,
			[Description("Bolivia (English)")]
			Bolivia(english),
			[Description("Botswana")]
			Botswana,
			[Description("Brazil")]
			Brazil,
			[Description("Brazil (English)")]
			Brazil(english),
			[Description("Brunei Darussalam")]
			BruneiDarussalam,
			[Description("Burkina Faso")]
			BurkinaFaso,
			[Description("Cambodia")]
			Cambodia,
			[Description("Canada")]
			Canada,
			[Description("Canada (French)")]
			Canada(french),
			[Description("Cape Verde")]
			CapeVerde,
			[Description("Cayman Islands")]
			CaymanIslands,
			[Description("Chad")]
			Chad,
			[Description("Chile")]
			Chile,
			[Description("Chile (English)")]
			Chile(english),
			[Description("Colombia")]
			Colombia,
			[Description("Colombia (English)")]
			Colombia(english),
			[Description("Congo, Republic of the")]
			CongoRepublicOfThe,
			[Description("Costa Rica")]
			CostaRica,
			[Description("Costa Rica (English)")]
			CostaRica(english),
			[Description("Cyprus")]
			Cyprus,
			[Description("Denmark")]
			Denmark,
			[Description("Denmark (English)")]
			Denmark(english),
			[Description("Germany")]
			Germany,
			[Description("Germany (English)")]
			Germany(english),
			[Description("Dominica")]
			Dominica,
			[Description("Dominica (English)")]
			Dominica(english),
			[Description("Ecuador")]
			Ecuador,
			[Description("Ecuador (English)")]
			Ecuador(english),
			[Description("Estonia")]
			Estonia,
			[Description("Egypt")]
			Egypt,
			[Description("El Salvador")]
			ElSalvador,
			[Description("El Salvador (English)")]
			ElSalvador(english),
			[Description("Spain")]
			Spain,
			[Description("Spain (English)")]
			Spain(english),
			[Description("Fiji")]
			Fiji,
			[Description("France")]
			France,
			[Description("France (English)")]
			France(english),
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
			Guatemala(english),
			[Description("Guinea-Bissau")]
			Guineabissau,
			[Description("Guyana")]
			Guyana,
			[Description("Honduras")]
			Honduras,
			[Description("Honduras (English)")]
			Honduras(english),
			[Description("Hong Kong")]
			HongKong,
			[Description("Hong Kong (English)")]
			HongKong(english),
			[Description("Croatia")]
			Croatia,
			[Description("Iceland")]
			Iceland,
			[Description("India")]
			India,
			[Description("Indonesia")]
			Indonesia,
			[Description("Indonesia (English)")]
			Indonesia(english),
			[Description("Ireland")]
			Ireland,
			[Description("Israel")]
			Israel,
			[Description("Italy")]
			Italy,
			[Description("Italy (English)")]
			Italy(english),
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
			Luxembourg(french),
			[Description("Luxembourg (English)")]
			Luxembourg(english),
			[Description("Macau")]
			Macau,
			[Description("Macau (English)")]
			Macau(english),
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
			Malaysia(english),
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
			Mexico(english),
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
			Netherlands(english),
			[Description("Nepal")]
			Nepal,
			[Description("New Zealand")]
			NewZealand,
			[Description("Nicaragua")]
			Nicaragua,
			[Description("Nicaragua (English)")]
			Nicaragua(english),
			[Description("Niger")]
			Niger,
			[Description("Nigeria")]
			Nigeria,
			[Description("Norway")]
			Norway,
			[Description("Norway (English)")]
			Norway(english),
			[Description("Oman")]
			Oman,
			[Description("Austria")]
			Austria,
			[Description("Austria (English)")]
			Austria(english),
			[Description("Pakistan")]
			Pakistan,
			[Description("Palau")]
			Palau,
			[Description("Panama")]
			Panama,
			[Description("Panama (English)")]
			Panama(english),
			[Description("Papua New Guinea")]
			PapuaNewGuinea,
			[Description("Paraguay")]
			Paraguay,
			[Description("Paraguay (English)")]
			Paraguay(english),
			[Description("Peru")]
			Peru,
			[Description("Philippines")]
			Philippines,
			[Description("Poland")]
			Poland,
			[Description("Portugal")]
			Portugal,
			[Description("Portugal (English)")]
			Portugal(english),
			[Description("Dominican Republic")]
			DominicanRepublic,
			[Description("Dominican Republic (English)")]
			DominicanRepublic(english),
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
			Switzerland(french),
			[Description("Switzerland (English)")]
			Switzerland(english),
			[Description("Switzerland (Italian)")]
			Switzerland(italian),
			[Description("Senegal")]
			Senegal,
			[Description("Seychelles")]
			Seychelles,
			[Description("Sierra Leone")]
			SierraLeone,
			[Description("Singapore")]
			Singapore,
			[Description("Singapore (English)")]
			Singapore(english),
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
			Finland(english),
			[Description("Suriname")]
			Suriname,
			[Description("Suriname (English)")]
			Suriname(english),
			[Description("Sweden")]
			Sweden,
			[Description("Sweden (English)")]
			Sweden(english),
			[Description("Swaziland")]
			Swaziland,
			[Description("Tajikistan")]
			Tajikistan,
			[Description("Tanzania")]
			Tanzania,
			[Description("Thailand")]
			Thailand,
			[Description("Thailand (English)")]
			Thailand(english),
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
			Turkey(english),
			[Description("United Kingdom")]
			UnitedKingdom,
			[Description("United States")]
			UnitedStates,
			[Description("United States (Spanish)")]
			UnitedStates(spanish),
			[Description("Uganda")]
			Uganda,
			[Description("Qatar")]
			Qatar,
			[Description("United Arab Emirates")]
			UnitedArabEmirates,
			[Description("Uruguay")]
			Uruguay,
			[Description("Uruguay (English)")]
			Uruguay(english),
			[Description("Uzbekistan")]
			Uzbekistan,
			[Description("Venezuela")]
			Venezuela,
			[Description("Venezuela (English)")]
			Venezuela(english),
			[Description("Vietnam")]
			Vietnam,
			[Description("Vietnam (English)")]
			Vietnam(english),
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
			Russia(english),
			[Description("Korea, Republic Of")]
			KoreaRepublicOf,
			[Description("Korea, Republic Of (English)")]
			KoreaRepublicOf(english),
			[Description("China")]
			China,
			[Description("China (English)")]
			China(english),
			[Description("Taiwan")]
			Taiwan,
			[Description("Taiwan (English)")]
			Taiwan(english),
			[Description("Japan")]
			Japan,
			[Description("Japan (English)")]
			Japan(english),
		}

		internal static class CountryExtensions {
			public static String GetCode(this Country country) {
				switch (country) {
					case Country.Albania:
						return @"al";
					case Country.CzechRepublic:
						return @"cz";
					case Country.Ukraine:
						return @"ua";
					case Country.Algeria:
						return @"dz";
					case Country.Angola:
						return @"ao";
					case Country.Anguilla:
						return @"ai";
					case Country.AntiguaAndBarbuda:
						return @"ag";
					case Country.Argentina:
						return @"ar";
					case Country.Argentina(english):
						return @"ar_en";
					case Country.Armenia:
						return @"am";
					case Country.Australia:
						return @"au";
					case Country.Azerbaijan:
						return @"az";
					case Country.Bahamas:
						return @"bs";
					case Country.Bahrain:
						return @"bh";
					case Country.Barbados:
						return @"bb";
					case Country.Belarus:
						return @"by";
					case Country.Belgium:
						return @"be";
					case Country.Belgium(english):
						return @"be_en";
					case Country.Belgium(french):
						return @"be_fr";
					case Country.Belize:
						return @"bz";
					case Country.Belize(spanish):
						return @"bz_es";
					case Country.Benin:
						return @"bj";
					case Country.Bermuda:
						return @"bm";
					case Country.Bhutan:
						return @"bt";
					case Country.Bolivia:
						return @"bo";
					case Country.Bolivia(english):
						return @"bo_en";
					case Country.Botswana:
						return @"bw";
					case Country.Brazil:
						return @"br";
					case Country.Brazil(english):
						return @"br_en";
					case Country.BruneiDarussalam:
						return @"bn";
					case Country.BurkinaFaso:
						return @"bf";
					case Country.Cambodia:
						return @"kh";
					case Country.Canada:
						return @"ca";
					case Country.Canada(french):
						return @"ca_fr";
					case Country.CapeVerde:
						return @"cv";
					case Country.CaymanIslands:
						return @"ky";
					case Country.Chad:
						return @"td";
					case Country.Chile:
						return @"cl";
					case Country.Chile(english):
						return @"cl_en";
					case Country.Colombia:
						return @"co";
					case Country.Colombia(english):
						return @"co_en";
					case Country.CongoRepublicOfThe:
						return @"cg";
					case Country.CostaRica:
						return @"cr";
					case Country.CostaRica(english):
						return @"cr_en";
					case Country.Cyprus:
						return @"cy";
					case Country.Denmark:
						return @"dk";
					case Country.Denmark(english):
						return @"dk_en";
					case Country.Germany:
						return @"de";
					case Country.Germany(english):
						return @"de_en";
					case Country.Dominica:
						return @"dm";
					case Country.Dominica(english):
						return @"dm_en";
					case Country.Ecuador:
						return @"ec";
					case Country.Ecuador(english):
						return @"ec_en";
					case Country.Estonia:
						return @"ee";
					case Country.Egypt:
						return @"eg";
					case Country.ElSalvador:
						return @"sv";
					case Country.ElSalvador(english):
						return @"sv_en";
					case Country.Spain:
						return @"es";
					case Country.Spain(english):
						return @"es_en";
					case Country.Fiji:
						return @"fj";
					case Country.France:
						return @"fr";
					case Country.France(english):
						return @"fr_en";
					case Country.Gambia:
						return @"gm";
					case Country.Ghana:
						return @"gh";
					case Country.Greece:
						return @"gr";
					case Country.Grenada:
						return @"gd";
					case Country.Guatemala:
						return @"gt";
					case Country.Guatemala(english):
						return @"gt_en";
					case Country.Guineabissau:
						return @"gw";
					case Country.Guyana:
						return @"gy";
					case Country.Honduras:
						return @"hn";
					case Country.Honduras(english):
						return @"hn_en";
					case Country.HongKong:
						return @"hk";
					case Country.HongKong(english):
						return @"hk_en";
					case Country.Croatia:
						return @"hr";
					case Country.Iceland:
						return @"is";
					case Country.India:
						return @"in";
					case Country.Indonesia:
						return @"id";
					case Country.Indonesia(english):
						return @"id_en";
					case Country.Ireland:
						return @"ie";
					case Country.Israel:
						return @"il";
					case Country.Italy:
						return @"it";
					case Country.Italy(english):
						return @"it_en";
					case Country.Jamaica:
						return @"jm";
					case Country.Jordan:
						return @"jo";
					case Country.Kazakhstan:
						return @"kz";
					case Country.Kenya:
						return @"ke";
					case Country.Kuwait:
						return @"kw";
					case Country.Kyrgyzstan:
						return @"kg";
					case Country.LaoPeoplesDemocraticRepublic:
						return @"la";
					case Country.Latvia:
						return @"lv";
					case Country.Lebanon:
						return @"lb";
					case Country.Liberia:
						return @"lr";
					case Country.Lithuania:
						return @"lt";
					case Country.Luxembourg:
						return @"lu";
					case Country.Luxembourg(french):
						return @"lu_fr";
					case Country.Luxembourg(english):
						return @"lu_en";
					case Country.Macau:
						return @"mo";
					case Country.Macau(english):
						return @"mo_en";
					case Country.Macedonia:
						return @"mk";
					case Country.Madagascar:
						return @"mg";
					case Country.Hungary:
						return @"hu";
					case Country.Malawi:
						return @"mw";
					case Country.Malaysia:
						return @"my";
					case Country.Malaysia(english):
						return @"my_en";
					case Country.Mali:
						return @"ml";
					case Country.Malta:
						return @"mt";
					case Country.Mauritania:
						return @"mr";
					case Country.Mauritius:
						return @"mu";
					case Country.Mexico:
						return @"mx";
					case Country.Mexico(english):
						return @"mx_en";
					case Country.MicronesiaFederatedStatesOf:
						return @"fm";
					case Country.Moldova:
						return @"md";
					case Country.Mongolia:
						return @"mn";
					case Country.Montserrat:
						return @"ms";
					case Country.Mozambique:
						return @"mz";
					case Country.Namibia:
						return @"na";
					case Country.Netherlands:
						return @"nl";
					case Country.Netherlands(english):
						return @"nl_en";
					case Country.Nepal:
						return @"np";
					case Country.NewZealand:
						return @"nz";
					case Country.Nicaragua:
						return @"ni";
					case Country.Nicaragua(english):
						return @"ni_en";
					case Country.Niger:
						return @"ne";
					case Country.Nigeria:
						return @"ng";
					case Country.Norway:
						return @"no";
					case Country.Norway(english):
						return @"no_en";
					case Country.Oman:
						return @"om";
					case Country.Austria:
						return @"at";
					case Country.Austria(english):
						return @"at_en";
					case Country.Pakistan:
						return @"pk";
					case Country.Palau:
						return @"pw";
					case Country.Panama:
						return @"pa";
					case Country.Panama(english):
						return @"pa_en";
					case Country.PapuaNewGuinea:
						return @"pg";
					case Country.Paraguay:
						return @"py";
					case Country.Paraguay(english):
						return @"py_en";
					case Country.Peru:
						return @"pe";
					case Country.Philippines:
						return @"ph";
					case Country.Poland:
						return @"pl";
					case Country.Portugal:
						return @"pt";
					case Country.Portugal(english):
						return @"pt_en";
					case Country.DominicanRepublic:
						return @"do";
					case Country.DominicanRepublic(english):
						return @"do_en";
					case Country.Romania:
						return @"ro";
					case Country.StKittsAndNevis:
						return @"kn";
					case Country.StLucia:
						return @"lc";
					case Country.StVincentAndTheGrenadines:
						return @"vc";
					case Country.SaudiArabia:
						return @"sa";
					case Country.SãoToméAndPríncipe:
						return @"st";
					case Country.Switzerland:
						return @"ch";
					case Country.Switzerland(french):
						return @"ch_fr";
					case Country.Switzerland(english):
						return @"ch_en";
					case Country.Switzerland(italian):
						return @"ch_it";
					case Country.Senegal:
						return @"sn";
					case Country.Seychelles:
						return @"sc";
					case Country.SierraLeone:
						return @"sl";
					case Country.Singapore:
						return @"sg";
					case Country.Singapore(english):
						return @"sg_en";
					case Country.Slovakia:
						return @"sk";
					case Country.Slovenia:
						return @"si";
					case Country.SolomonIslands:
						return @"sb";
					case Country.SouthAfrica:
						return @"za";
					case Country.SriLanka:
						return @"lk";
					case Country.Finland:
						return @"fi";
					case Country.Finland(english):
						return @"fi_en";
					case Country.Suriname:
						return @"sr";
					case Country.Suriname(english):
						return @"sr_en";
					case Country.Sweden:
						return @"se";
					case Country.Sweden(english):
						return @"se_en";
					case Country.Swaziland:
						return @"sz";
					case Country.Tajikistan:
						return @"tj";
					case Country.Tanzania:
						return @"tz";
					case Country.Thailand:
						return @"th";
					case Country.Thailand(english):
						return @"th_en";
					case Country.TrinidadAndTobago:
						return @"tt";
					case Country.Tunisia:
						return @"tn";
					case Country.Turkmenistan:
						return @"tm";
					case Country.TurksAndCaicos:
						return @"tc";
					case Country.Turkey:
						return @"tr";
					case Country.Turkey(english):
						return @"tr_en";
					case Country.UnitedKingdom:
						return @"gb";
					case Country.UnitedStates:
						return @"us";
					case Country.UnitedStates(spanish):
						return @"us_es";
					case Country.Uganda:
						return @"ug";
					case Country.Qatar:
						return @"qa";
					case Country.UnitedArabEmirates:
						return @"ae";
					case Country.Uruguay:
						return @"uy";
					case Country.Uruguay(english):
						return @"uy_en";
					case Country.Uzbekistan:
						return @"uz";
					case Country.Venezuela:
						return @"ve";
					case Country.Venezuela(english):
						return @"ve_en";
					case Country.Vietnam:
						return @"vn";
					case Country.Vietnam(english):
						return @"vn_en";
					case Country.BritishVirginIslands:
						return @"vg";
					case Country.Yemen:
						return @"ye";
					case Country.Zimbabwe:
						return @"zw";
					case Country.Bulgaria:
						return @"bg";
					case Country.Russia:
						return @"ru";
					case Country.Russia(english):
						return @"ru_en";
					case Country.KoreaRepublicOf:
						return @"kr";
					case Country.KoreaRepublicOf(english):
						return @"kr_en";
					case Country.China:
						return @"cn";
					case Country.China(english):
						return @"cn_en";
					case Country.Taiwan:
						return @"tw";
					case Country.Taiwan(english):
						return @"tw_en";
					case Country.Japan:
						return @"jp";
					case Country.Japan(english):
						return @"jp_en";
				}
				throw new NotImplementedException();
			}
		}
	}
}