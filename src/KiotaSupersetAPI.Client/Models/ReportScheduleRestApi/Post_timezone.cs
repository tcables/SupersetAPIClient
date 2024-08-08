
using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>A timezone string that represents the location of the timezone.</summary>
public enum Post_timezone
{
    [EnumMember(Value = "Africa/Abidjan")]
#pragma warning disable CS1591
    AfricaAbidjan,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Accra")]
#pragma warning disable CS1591
    AfricaAccra,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Addis_Ababa")]
#pragma warning disable CS1591
    AfricaAddis_Ababa,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Algiers")]
#pragma warning disable CS1591
    AfricaAlgiers,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Asmara")]
#pragma warning disable CS1591
    AfricaAsmara,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Asmera")]
#pragma warning disable CS1591
    AfricaAsmera,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Bamako")]
#pragma warning disable CS1591
    AfricaBamako,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Bangui")]
#pragma warning disable CS1591
    AfricaBangui,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Banjul")]
#pragma warning disable CS1591
    AfricaBanjul,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Bissau")]
#pragma warning disable CS1591
    AfricaBissau,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Blantyre")]
#pragma warning disable CS1591
    AfricaBlantyre,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Brazzaville")]
#pragma warning disable CS1591
    AfricaBrazzaville,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Bujumbura")]
#pragma warning disable CS1591
    AfricaBujumbura,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Cairo")]
#pragma warning disable CS1591
    AfricaCairo,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Casablanca")]
#pragma warning disable CS1591
    AfricaCasablanca,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Ceuta")]
#pragma warning disable CS1591
    AfricaCeuta,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Conakry")]
#pragma warning disable CS1591
    AfricaConakry,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Dakar")]
#pragma warning disable CS1591
    AfricaDakar,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Dar_es_Salaam")]
#pragma warning disable CS1591
    AfricaDar_es_Salaam,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Djibouti")]
#pragma warning disable CS1591
    AfricaDjibouti,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Douala")]
#pragma warning disable CS1591
    AfricaDouala,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/El_Aaiun")]
#pragma warning disable CS1591
    AfricaEl_Aaiun,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Freetown")]
#pragma warning disable CS1591
    AfricaFreetown,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Gaborone")]
#pragma warning disable CS1591
    AfricaGaborone,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Harare")]
#pragma warning disable CS1591
    AfricaHarare,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Johannesburg")]
#pragma warning disable CS1591
    AfricaJohannesburg,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Juba")]
#pragma warning disable CS1591
    AfricaJuba,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Kampala")]
#pragma warning disable CS1591
    AfricaKampala,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Khartoum")]
#pragma warning disable CS1591
    AfricaKhartoum,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Kigali")]
#pragma warning disable CS1591
    AfricaKigali,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Kinshasa")]
#pragma warning disable CS1591
    AfricaKinshasa,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Lagos")]
#pragma warning disable CS1591
    AfricaLagos,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Libreville")]
#pragma warning disable CS1591
    AfricaLibreville,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Lome")]
#pragma warning disable CS1591
    AfricaLome,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Luanda")]
#pragma warning disable CS1591
    AfricaLuanda,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Lubumbashi")]
#pragma warning disable CS1591
    AfricaLubumbashi,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Lusaka")]
#pragma warning disable CS1591
    AfricaLusaka,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Malabo")]
#pragma warning disable CS1591
    AfricaMalabo,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Maputo")]
#pragma warning disable CS1591
    AfricaMaputo,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Maseru")]
#pragma warning disable CS1591
    AfricaMaseru,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Mbabane")]
#pragma warning disable CS1591
    AfricaMbabane,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Mogadishu")]
#pragma warning disable CS1591
    AfricaMogadishu,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Monrovia")]
#pragma warning disable CS1591
    AfricaMonrovia,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Nairobi")]
#pragma warning disable CS1591
    AfricaNairobi,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Ndjamena")]
#pragma warning disable CS1591
    AfricaNdjamena,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Niamey")]
#pragma warning disable CS1591
    AfricaNiamey,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Nouakchott")]
#pragma warning disable CS1591
    AfricaNouakchott,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Ouagadougou")]
#pragma warning disable CS1591
    AfricaOuagadougou,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Porto-Novo")]
#pragma warning disable CS1591
    AfricaPortoNovo,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Sao_Tome")]
#pragma warning disable CS1591
    AfricaSao_Tome,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Timbuktu")]
#pragma warning disable CS1591
    AfricaTimbuktu,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Tripoli")]
#pragma warning disable CS1591
    AfricaTripoli,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Tunis")]
#pragma warning disable CS1591
    AfricaTunis,
#pragma warning restore CS1591
    [EnumMember(Value = "Africa/Windhoek")]
#pragma warning disable CS1591
    AfricaWindhoek,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Adak")]
#pragma warning disable CS1591
    AmericaAdak,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Anchorage")]
#pragma warning disable CS1591
    AmericaAnchorage,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Anguilla")]
#pragma warning disable CS1591
    AmericaAnguilla,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Antigua")]
#pragma warning disable CS1591
    AmericaAntigua,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Araguaina")]
#pragma warning disable CS1591
    AmericaAraguaina,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/Buenos_Aires")]
#pragma warning disable CS1591
    AmericaArgentinaBuenos_Aires,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/Catamarca")]
#pragma warning disable CS1591
    AmericaArgentinaCatamarca,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/ComodRivadavia")]
#pragma warning disable CS1591
    AmericaArgentinaComodRivadavia,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/Cordoba")]
#pragma warning disable CS1591
    AmericaArgentinaCordoba,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/Jujuy")]
#pragma warning disable CS1591
    AmericaArgentinaJujuy,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/La_Rioja")]
#pragma warning disable CS1591
    AmericaArgentinaLa_Rioja,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/Mendoza")]
#pragma warning disable CS1591
    AmericaArgentinaMendoza,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/Rio_Gallegos")]
#pragma warning disable CS1591
    AmericaArgentinaRio_Gallegos,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/Salta")]
#pragma warning disable CS1591
    AmericaArgentinaSalta,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/San_Juan")]
#pragma warning disable CS1591
    AmericaArgentinaSan_Juan,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/San_Luis")]
#pragma warning disable CS1591
    AmericaArgentinaSan_Luis,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/Tucuman")]
#pragma warning disable CS1591
    AmericaArgentinaTucuman,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Argentina/Ushuaia")]
#pragma warning disable CS1591
    AmericaArgentinaUshuaia,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Aruba")]
#pragma warning disable CS1591
    AmericaAruba,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Asuncion")]
#pragma warning disable CS1591
    AmericaAsuncion,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Atikokan")]
#pragma warning disable CS1591
    AmericaAtikokan,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Atka")]
#pragma warning disable CS1591
    AmericaAtka,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Bahia")]
#pragma warning disable CS1591
    AmericaBahia,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Bahia_Banderas")]
#pragma warning disable CS1591
    AmericaBahia_Banderas,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Barbados")]
#pragma warning disable CS1591
    AmericaBarbados,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Belem")]
#pragma warning disable CS1591
    AmericaBelem,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Belize")]
#pragma warning disable CS1591
    AmericaBelize,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Blanc-Sablon")]
#pragma warning disable CS1591
    AmericaBlancSablon,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Boa_Vista")]
#pragma warning disable CS1591
    AmericaBoa_Vista,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Bogota")]
#pragma warning disable CS1591
    AmericaBogota,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Boise")]
#pragma warning disable CS1591
    AmericaBoise,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Buenos_Aires")]
#pragma warning disable CS1591
    AmericaBuenos_Aires,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Cambridge_Bay")]
#pragma warning disable CS1591
    AmericaCambridge_Bay,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Campo_Grande")]
#pragma warning disable CS1591
    AmericaCampo_Grande,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Cancun")]
#pragma warning disable CS1591
    AmericaCancun,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Caracas")]
#pragma warning disable CS1591
    AmericaCaracas,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Catamarca")]
#pragma warning disable CS1591
    AmericaCatamarca,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Cayenne")]
#pragma warning disable CS1591
    AmericaCayenne,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Cayman")]
#pragma warning disable CS1591
    AmericaCayman,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Chicago")]
#pragma warning disable CS1591
    AmericaChicago,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Chihuahua")]
#pragma warning disable CS1591
    AmericaChihuahua,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Coral_Harbour")]
#pragma warning disable CS1591
    AmericaCoral_Harbour,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Cordoba")]
#pragma warning disable CS1591
    AmericaCordoba,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Costa_Rica")]
#pragma warning disable CS1591
    AmericaCosta_Rica,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Creston")]
#pragma warning disable CS1591
    AmericaCreston,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Cuiaba")]
#pragma warning disable CS1591
    AmericaCuiaba,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Curacao")]
#pragma warning disable CS1591
    AmericaCuracao,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Danmarkshavn")]
#pragma warning disable CS1591
    AmericaDanmarkshavn,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Dawson")]
#pragma warning disable CS1591
    AmericaDawson,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Dawson_Creek")]
#pragma warning disable CS1591
    AmericaDawson_Creek,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Denver")]
#pragma warning disable CS1591
    AmericaDenver,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Detroit")]
#pragma warning disable CS1591
    AmericaDetroit,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Dominica")]
#pragma warning disable CS1591
    AmericaDominica,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Edmonton")]
#pragma warning disable CS1591
    AmericaEdmonton,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Eirunepe")]
#pragma warning disable CS1591
    AmericaEirunepe,
#pragma warning restore CS1591
    [EnumMember(Value = "America/El_Salvador")]
#pragma warning disable CS1591
    AmericaEl_Salvador,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Ensenada")]
#pragma warning disable CS1591
    AmericaEnsenada,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Fort_Nelson")]
#pragma warning disable CS1591
    AmericaFort_Nelson,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Fort_Wayne")]
#pragma warning disable CS1591
    AmericaFort_Wayne,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Fortaleza")]
#pragma warning disable CS1591
    AmericaFortaleza,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Glace_Bay")]
#pragma warning disable CS1591
    AmericaGlace_Bay,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Godthab")]
#pragma warning disable CS1591
    AmericaGodthab,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Goose_Bay")]
#pragma warning disable CS1591
    AmericaGoose_Bay,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Grand_Turk")]
#pragma warning disable CS1591
    AmericaGrand_Turk,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Grenada")]
#pragma warning disable CS1591
    AmericaGrenada,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Guadeloupe")]
#pragma warning disable CS1591
    AmericaGuadeloupe,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Guatemala")]
#pragma warning disable CS1591
    AmericaGuatemala,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Guayaquil")]
#pragma warning disable CS1591
    AmericaGuayaquil,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Guyana")]
#pragma warning disable CS1591
    AmericaGuyana,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Halifax")]
#pragma warning disable CS1591
    AmericaHalifax,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Havana")]
#pragma warning disable CS1591
    AmericaHavana,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Hermosillo")]
#pragma warning disable CS1591
    AmericaHermosillo,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Indiana/Indianapolis")]
#pragma warning disable CS1591
    AmericaIndianaIndianapolis,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Indiana/Knox")]
#pragma warning disable CS1591
    AmericaIndianaKnox,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Indiana/Marengo")]
#pragma warning disable CS1591
    AmericaIndianaMarengo,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Indiana/Petersburg")]
#pragma warning disable CS1591
    AmericaIndianaPetersburg,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Indiana/Tell_City")]
#pragma warning disable CS1591
    AmericaIndianaTell_City,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Indiana/Vevay")]
#pragma warning disable CS1591
    AmericaIndianaVevay,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Indiana/Vincennes")]
#pragma warning disable CS1591
    AmericaIndianaVincennes,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Indiana/Winamac")]
#pragma warning disable CS1591
    AmericaIndianaWinamac,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Indianapolis")]
#pragma warning disable CS1591
    AmericaIndianapolis,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Inuvik")]
#pragma warning disable CS1591
    AmericaInuvik,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Iqaluit")]
#pragma warning disable CS1591
    AmericaIqaluit,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Jamaica")]
#pragma warning disable CS1591
    AmericaJamaica,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Jujuy")]
#pragma warning disable CS1591
    AmericaJujuy,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Juneau")]
#pragma warning disable CS1591
    AmericaJuneau,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Kentucky/Louisville")]
#pragma warning disable CS1591
    AmericaKentuckyLouisville,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Kentucky/Monticello")]
#pragma warning disable CS1591
    AmericaKentuckyMonticello,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Knox_IN")]
#pragma warning disable CS1591
    AmericaKnox_IN,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Kralendijk")]
#pragma warning disable CS1591
    AmericaKralendijk,
#pragma warning restore CS1591
    [EnumMember(Value = "America/La_Paz")]
#pragma warning disable CS1591
    AmericaLa_Paz,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Lima")]
#pragma warning disable CS1591
    AmericaLima,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Los_Angeles")]
#pragma warning disable CS1591
    AmericaLos_Angeles,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Louisville")]
#pragma warning disable CS1591
    AmericaLouisville,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Lower_Princes")]
#pragma warning disable CS1591
    AmericaLower_Princes,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Maceio")]
#pragma warning disable CS1591
    AmericaMaceio,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Managua")]
#pragma warning disable CS1591
    AmericaManagua,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Manaus")]
#pragma warning disable CS1591
    AmericaManaus,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Marigot")]
#pragma warning disable CS1591
    AmericaMarigot,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Martinique")]
#pragma warning disable CS1591
    AmericaMartinique,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Matamoros")]
#pragma warning disable CS1591
    AmericaMatamoros,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Mazatlan")]
#pragma warning disable CS1591
    AmericaMazatlan,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Mendoza")]
#pragma warning disable CS1591
    AmericaMendoza,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Menominee")]
#pragma warning disable CS1591
    AmericaMenominee,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Merida")]
#pragma warning disable CS1591
    AmericaMerida,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Metlakatla")]
#pragma warning disable CS1591
    AmericaMetlakatla,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Mexico_City")]
#pragma warning disable CS1591
    AmericaMexico_City,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Miquelon")]
#pragma warning disable CS1591
    AmericaMiquelon,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Moncton")]
#pragma warning disable CS1591
    AmericaMoncton,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Monterrey")]
#pragma warning disable CS1591
    AmericaMonterrey,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Montevideo")]
#pragma warning disable CS1591
    AmericaMontevideo,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Montreal")]
#pragma warning disable CS1591
    AmericaMontreal,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Montserrat")]
#pragma warning disable CS1591
    AmericaMontserrat,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Nassau")]
#pragma warning disable CS1591
    AmericaNassau,
#pragma warning restore CS1591
    [EnumMember(Value = "America/New_York")]
#pragma warning disable CS1591
    AmericaNew_York,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Nipigon")]
#pragma warning disable CS1591
    AmericaNipigon,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Nome")]
#pragma warning disable CS1591
    AmericaNome,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Noronha")]
#pragma warning disable CS1591
    AmericaNoronha,
#pragma warning restore CS1591
    [EnumMember(Value = "America/North_Dakota/Beulah")]
#pragma warning disable CS1591
    AmericaNorth_DakotaBeulah,
#pragma warning restore CS1591
    [EnumMember(Value = "America/North_Dakota/Center")]
#pragma warning disable CS1591
    AmericaNorth_DakotaCenter,
#pragma warning restore CS1591
    [EnumMember(Value = "America/North_Dakota/New_Salem")]
#pragma warning disable CS1591
    AmericaNorth_DakotaNew_Salem,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Nuuk")]
#pragma warning disable CS1591
    AmericaNuuk,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Ojinaga")]
#pragma warning disable CS1591
    AmericaOjinaga,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Panama")]
#pragma warning disable CS1591
    AmericaPanama,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Pangnirtung")]
#pragma warning disable CS1591
    AmericaPangnirtung,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Paramaribo")]
#pragma warning disable CS1591
    AmericaParamaribo,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Phoenix")]
#pragma warning disable CS1591
    AmericaPhoenix,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Port-au-Prince")]
#pragma warning disable CS1591
    AmericaPortAuPrince,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Port_of_Spain")]
#pragma warning disable CS1591
    AmericaPort_of_Spain,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Porto_Acre")]
#pragma warning disable CS1591
    AmericaPorto_Acre,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Porto_Velho")]
#pragma warning disable CS1591
    AmericaPorto_Velho,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Puerto_Rico")]
#pragma warning disable CS1591
    AmericaPuerto_Rico,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Punta_Arenas")]
#pragma warning disable CS1591
    AmericaPunta_Arenas,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Rainy_River")]
#pragma warning disable CS1591
    AmericaRainy_River,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Rankin_Inlet")]
#pragma warning disable CS1591
    AmericaRankin_Inlet,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Recife")]
#pragma warning disable CS1591
    AmericaRecife,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Regina")]
#pragma warning disable CS1591
    AmericaRegina,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Resolute")]
#pragma warning disable CS1591
    AmericaResolute,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Rio_Branco")]
#pragma warning disable CS1591
    AmericaRio_Branco,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Rosario")]
#pragma warning disable CS1591
    AmericaRosario,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Santa_Isabel")]
#pragma warning disable CS1591
    AmericaSanta_Isabel,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Santarem")]
#pragma warning disable CS1591
    AmericaSantarem,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Santiago")]
#pragma warning disable CS1591
    AmericaSantiago,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Santo_Domingo")]
#pragma warning disable CS1591
    AmericaSanto_Domingo,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Sao_Paulo")]
#pragma warning disable CS1591
    AmericaSao_Paulo,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Scoresbysund")]
#pragma warning disable CS1591
    AmericaScoresbysund,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Shiprock")]
#pragma warning disable CS1591
    AmericaShiprock,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Sitka")]
#pragma warning disable CS1591
    AmericaSitka,
#pragma warning restore CS1591
    [EnumMember(Value = "America/St_Barthelemy")]
#pragma warning disable CS1591
    AmericaSt_Barthelemy,
#pragma warning restore CS1591
    [EnumMember(Value = "America/St_Johns")]
#pragma warning disable CS1591
    AmericaSt_Johns,
#pragma warning restore CS1591
    [EnumMember(Value = "America/St_Kitts")]
#pragma warning disable CS1591
    AmericaSt_Kitts,
#pragma warning restore CS1591
    [EnumMember(Value = "America/St_Lucia")]
#pragma warning disable CS1591
    AmericaSt_Lucia,
#pragma warning restore CS1591
    [EnumMember(Value = "America/St_Thomas")]
#pragma warning disable CS1591
    AmericaSt_Thomas,
#pragma warning restore CS1591
    [EnumMember(Value = "America/St_Vincent")]
#pragma warning disable CS1591
    AmericaSt_Vincent,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Swift_Current")]
#pragma warning disable CS1591
    AmericaSwift_Current,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Tegucigalpa")]
#pragma warning disable CS1591
    AmericaTegucigalpa,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Thule")]
#pragma warning disable CS1591
    AmericaThule,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Thunder_Bay")]
#pragma warning disable CS1591
    AmericaThunder_Bay,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Tijuana")]
#pragma warning disable CS1591
    AmericaTijuana,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Toronto")]
#pragma warning disable CS1591
    AmericaToronto,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Tortola")]
#pragma warning disable CS1591
    AmericaTortola,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Vancouver")]
#pragma warning disable CS1591
    AmericaVancouver,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Virgin")]
#pragma warning disable CS1591
    AmericaVirgin,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Whitehorse")]
#pragma warning disable CS1591
    AmericaWhitehorse,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Winnipeg")]
#pragma warning disable CS1591
    AmericaWinnipeg,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Yakutat")]
#pragma warning disable CS1591
    AmericaYakutat,
#pragma warning restore CS1591
    [EnumMember(Value = "America/Yellowknife")]
#pragma warning disable CS1591
    AmericaYellowknife,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/Casey")]
#pragma warning disable CS1591
    AntarcticaCasey,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/Davis")]
#pragma warning disable CS1591
    AntarcticaDavis,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/DumontDUrville")]
#pragma warning disable CS1591
    AntarcticaDumontDUrville,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/Macquarie")]
#pragma warning disable CS1591
    AntarcticaMacquarie,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/Mawson")]
#pragma warning disable CS1591
    AntarcticaMawson,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/McMurdo")]
#pragma warning disable CS1591
    AntarcticaMcMurdo,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/Palmer")]
#pragma warning disable CS1591
    AntarcticaPalmer,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/Rothera")]
#pragma warning disable CS1591
    AntarcticaRothera,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/South_Pole")]
#pragma warning disable CS1591
    AntarcticaSouth_Pole,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/Syowa")]
#pragma warning disable CS1591
    AntarcticaSyowa,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/Troll")]
#pragma warning disable CS1591
    AntarcticaTroll,
#pragma warning restore CS1591
    [EnumMember(Value = "Antarctica/Vostok")]
#pragma warning disable CS1591
    AntarcticaVostok,
#pragma warning restore CS1591
    [EnumMember(Value = "Arctic/Longyearbyen")]
#pragma warning disable CS1591
    ArcticLongyearbyen,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Aden")]
#pragma warning disable CS1591
    AsiaAden,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Almaty")]
#pragma warning disable CS1591
    AsiaAlmaty,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Amman")]
#pragma warning disable CS1591
    AsiaAmman,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Anadyr")]
#pragma warning disable CS1591
    AsiaAnadyr,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Aqtau")]
#pragma warning disable CS1591
    AsiaAqtau,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Aqtobe")]
#pragma warning disable CS1591
    AsiaAqtobe,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Ashgabat")]
#pragma warning disable CS1591
    AsiaAshgabat,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Ashkhabad")]
#pragma warning disable CS1591
    AsiaAshkhabad,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Atyrau")]
#pragma warning disable CS1591
    AsiaAtyrau,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Baghdad")]
#pragma warning disable CS1591
    AsiaBaghdad,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Bahrain")]
#pragma warning disable CS1591
    AsiaBahrain,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Baku")]
#pragma warning disable CS1591
    AsiaBaku,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Bangkok")]
#pragma warning disable CS1591
    AsiaBangkok,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Barnaul")]
#pragma warning disable CS1591
    AsiaBarnaul,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Beirut")]
#pragma warning disable CS1591
    AsiaBeirut,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Bishkek")]
#pragma warning disable CS1591
    AsiaBishkek,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Brunei")]
#pragma warning disable CS1591
    AsiaBrunei,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Calcutta")]
#pragma warning disable CS1591
    AsiaCalcutta,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Chita")]
#pragma warning disable CS1591
    AsiaChita,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Choibalsan")]
#pragma warning disable CS1591
    AsiaChoibalsan,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Chongqing")]
#pragma warning disable CS1591
    AsiaChongqing,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Chungking")]
#pragma warning disable CS1591
    AsiaChungking,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Colombo")]
#pragma warning disable CS1591
    AsiaColombo,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Dacca")]
#pragma warning disable CS1591
    AsiaDacca,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Damascus")]
#pragma warning disable CS1591
    AsiaDamascus,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Dhaka")]
#pragma warning disable CS1591
    AsiaDhaka,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Dili")]
#pragma warning disable CS1591
    AsiaDili,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Dubai")]
#pragma warning disable CS1591
    AsiaDubai,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Dushanbe")]
#pragma warning disable CS1591
    AsiaDushanbe,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Famagusta")]
#pragma warning disable CS1591
    AsiaFamagusta,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Gaza")]
#pragma warning disable CS1591
    AsiaGaza,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Harbin")]
#pragma warning disable CS1591
    AsiaHarbin,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Hebron")]
#pragma warning disable CS1591
    AsiaHebron,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Ho_Chi_Minh")]
#pragma warning disable CS1591
    AsiaHo_Chi_Minh,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Hong_Kong")]
#pragma warning disable CS1591
    AsiaHong_Kong,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Hovd")]
#pragma warning disable CS1591
    AsiaHovd,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Irkutsk")]
#pragma warning disable CS1591
    AsiaIrkutsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Istanbul")]
#pragma warning disable CS1591
    AsiaIstanbul,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Jakarta")]
#pragma warning disable CS1591
    AsiaJakarta,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Jayapura")]
#pragma warning disable CS1591
    AsiaJayapura,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Jerusalem")]
#pragma warning disable CS1591
    AsiaJerusalem,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Kabul")]
#pragma warning disable CS1591
    AsiaKabul,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Kamchatka")]
#pragma warning disable CS1591
    AsiaKamchatka,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Karachi")]
#pragma warning disable CS1591
    AsiaKarachi,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Kashgar")]
#pragma warning disable CS1591
    AsiaKashgar,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Kathmandu")]
#pragma warning disable CS1591
    AsiaKathmandu,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Katmandu")]
#pragma warning disable CS1591
    AsiaKatmandu,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Khandyga")]
#pragma warning disable CS1591
    AsiaKhandyga,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Kolkata")]
#pragma warning disable CS1591
    AsiaKolkata,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Krasnoyarsk")]
#pragma warning disable CS1591
    AsiaKrasnoyarsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Kuala_Lumpur")]
#pragma warning disable CS1591
    AsiaKuala_Lumpur,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Kuching")]
#pragma warning disable CS1591
    AsiaKuching,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Kuwait")]
#pragma warning disable CS1591
    AsiaKuwait,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Macao")]
#pragma warning disable CS1591
    AsiaMacao,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Macau")]
#pragma warning disable CS1591
    AsiaMacau,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Magadan")]
#pragma warning disable CS1591
    AsiaMagadan,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Makassar")]
#pragma warning disable CS1591
    AsiaMakassar,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Manila")]
#pragma warning disable CS1591
    AsiaManila,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Muscat")]
#pragma warning disable CS1591
    AsiaMuscat,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Nicosia")]
#pragma warning disable CS1591
    AsiaNicosia,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Novokuznetsk")]
#pragma warning disable CS1591
    AsiaNovokuznetsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Novosibirsk")]
#pragma warning disable CS1591
    AsiaNovosibirsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Omsk")]
#pragma warning disable CS1591
    AsiaOmsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Oral")]
#pragma warning disable CS1591
    AsiaOral,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Phnom_Penh")]
#pragma warning disable CS1591
    AsiaPhnom_Penh,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Pontianak")]
#pragma warning disable CS1591
    AsiaPontianak,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Pyongyang")]
#pragma warning disable CS1591
    AsiaPyongyang,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Qatar")]
#pragma warning disable CS1591
    AsiaQatar,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Qostanay")]
#pragma warning disable CS1591
    AsiaQostanay,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Qyzylorda")]
#pragma warning disable CS1591
    AsiaQyzylorda,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Rangoon")]
#pragma warning disable CS1591
    AsiaRangoon,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Riyadh")]
#pragma warning disable CS1591
    AsiaRiyadh,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Saigon")]
#pragma warning disable CS1591
    AsiaSaigon,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Sakhalin")]
#pragma warning disable CS1591
    AsiaSakhalin,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Samarkand")]
#pragma warning disable CS1591
    AsiaSamarkand,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Seoul")]
#pragma warning disable CS1591
    AsiaSeoul,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Shanghai")]
#pragma warning disable CS1591
    AsiaShanghai,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Singapore")]
#pragma warning disable CS1591
    AsiaSingapore,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Srednekolymsk")]
#pragma warning disable CS1591
    AsiaSrednekolymsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Taipei")]
#pragma warning disable CS1591
    AsiaTaipei,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Tashkent")]
#pragma warning disable CS1591
    AsiaTashkent,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Tbilisi")]
#pragma warning disable CS1591
    AsiaTbilisi,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Tehran")]
#pragma warning disable CS1591
    AsiaTehran,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Tel_Aviv")]
#pragma warning disable CS1591
    AsiaTel_Aviv,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Thimbu")]
#pragma warning disable CS1591
    AsiaThimbu,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Thimphu")]
#pragma warning disable CS1591
    AsiaThimphu,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Tokyo")]
#pragma warning disable CS1591
    AsiaTokyo,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Tomsk")]
#pragma warning disable CS1591
    AsiaTomsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Ujung_Pandang")]
#pragma warning disable CS1591
    AsiaUjung_Pandang,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Ulaanbaatar")]
#pragma warning disable CS1591
    AsiaUlaanbaatar,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Ulan_Bator")]
#pragma warning disable CS1591
    AsiaUlan_Bator,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Urumqi")]
#pragma warning disable CS1591
    AsiaUrumqi,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Ust-Nera")]
#pragma warning disable CS1591
    AsiaUstNera,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Vientiane")]
#pragma warning disable CS1591
    AsiaVientiane,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Vladivostok")]
#pragma warning disable CS1591
    AsiaVladivostok,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Yakutsk")]
#pragma warning disable CS1591
    AsiaYakutsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Yangon")]
#pragma warning disable CS1591
    AsiaYangon,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Yekaterinburg")]
#pragma warning disable CS1591
    AsiaYekaterinburg,
#pragma warning restore CS1591
    [EnumMember(Value = "Asia/Yerevan")]
#pragma warning disable CS1591
    AsiaYerevan,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Azores")]
#pragma warning disable CS1591
    AtlanticAzores,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Bermuda")]
#pragma warning disable CS1591
    AtlanticBermuda,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Canary")]
#pragma warning disable CS1591
    AtlanticCanary,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Cape_Verde")]
#pragma warning disable CS1591
    AtlanticCape_Verde,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Faeroe")]
#pragma warning disable CS1591
    AtlanticFaeroe,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Faroe")]
#pragma warning disable CS1591
    AtlanticFaroe,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Jan_Mayen")]
#pragma warning disable CS1591
    AtlanticJan_Mayen,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Madeira")]
#pragma warning disable CS1591
    AtlanticMadeira,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Reykjavik")]
#pragma warning disable CS1591
    AtlanticReykjavik,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/South_Georgia")]
#pragma warning disable CS1591
    AtlanticSouth_Georgia,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/St_Helena")]
#pragma warning disable CS1591
    AtlanticSt_Helena,
#pragma warning restore CS1591
    [EnumMember(Value = "Atlantic/Stanley")]
#pragma warning disable CS1591
    AtlanticStanley,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/ACT")]
#pragma warning disable CS1591
    AustraliaACT,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Adelaide")]
#pragma warning disable CS1591
    AustraliaAdelaide,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Brisbane")]
#pragma warning disable CS1591
    AustraliaBrisbane,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Broken_Hill")]
#pragma warning disable CS1591
    AustraliaBroken_Hill,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Canberra")]
#pragma warning disable CS1591
    AustraliaCanberra,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Currie")]
#pragma warning disable CS1591
    AustraliaCurrie,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Darwin")]
#pragma warning disable CS1591
    AustraliaDarwin,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Eucla")]
#pragma warning disable CS1591
    AustraliaEucla,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Hobart")]
#pragma warning disable CS1591
    AustraliaHobart,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/LHI")]
#pragma warning disable CS1591
    AustraliaLHI,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Lindeman")]
#pragma warning disable CS1591
    AustraliaLindeman,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Lord_Howe")]
#pragma warning disable CS1591
    AustraliaLord_Howe,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Melbourne")]
#pragma warning disable CS1591
    AustraliaMelbourne,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/NSW")]
#pragma warning disable CS1591
    AustraliaNSW,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/North")]
#pragma warning disable CS1591
    AustraliaNorth,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Perth")]
#pragma warning disable CS1591
    AustraliaPerth,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Queensland")]
#pragma warning disable CS1591
    AustraliaQueensland,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/South")]
#pragma warning disable CS1591
    AustraliaSouth,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Sydney")]
#pragma warning disable CS1591
    AustraliaSydney,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Tasmania")]
#pragma warning disable CS1591
    AustraliaTasmania,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Victoria")]
#pragma warning disable CS1591
    AustraliaVictoria,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/West")]
#pragma warning disable CS1591
    AustraliaWest,
#pragma warning restore CS1591
    [EnumMember(Value = "Australia/Yancowinna")]
#pragma warning disable CS1591
    AustraliaYancowinna,
#pragma warning restore CS1591
    [EnumMember(Value = "Brazil/Acre")]
#pragma warning disable CS1591
    BrazilAcre,
#pragma warning restore CS1591
    [EnumMember(Value = "Brazil/DeNoronha")]
#pragma warning disable CS1591
    BrazilDeNoronha,
#pragma warning restore CS1591
    [EnumMember(Value = "Brazil/East")]
#pragma warning disable CS1591
    BrazilEast,
#pragma warning restore CS1591
    [EnumMember(Value = "Brazil/West")]
#pragma warning disable CS1591
    BrazilWest,
#pragma warning restore CS1591
    [EnumMember(Value = "CET")]
#pragma warning disable CS1591
    CET,
#pragma warning restore CS1591
    [EnumMember(Value = "CST6CDT")]
#pragma warning disable CS1591
    CST6CDT,
#pragma warning restore CS1591
    [EnumMember(Value = "Canada/Atlantic")]
#pragma warning disable CS1591
    CanadaAtlantic,
#pragma warning restore CS1591
    [EnumMember(Value = "Canada/Central")]
#pragma warning disable CS1591
    CanadaCentral,
#pragma warning restore CS1591
    [EnumMember(Value = "Canada/Eastern")]
#pragma warning disable CS1591
    CanadaEastern,
#pragma warning restore CS1591
    [EnumMember(Value = "Canada/Mountain")]
#pragma warning disable CS1591
    CanadaMountain,
#pragma warning restore CS1591
    [EnumMember(Value = "Canada/Newfoundland")]
#pragma warning disable CS1591
    CanadaNewfoundland,
#pragma warning restore CS1591
    [EnumMember(Value = "Canada/Pacific")]
#pragma warning disable CS1591
    CanadaPacific,
#pragma warning restore CS1591
    [EnumMember(Value = "Canada/Saskatchewan")]
#pragma warning disable CS1591
    CanadaSaskatchewan,
#pragma warning restore CS1591
    [EnumMember(Value = "Canada/Yukon")]
#pragma warning disable CS1591
    CanadaYukon,
#pragma warning restore CS1591
    [EnumMember(Value = "Chile/Continental")]
#pragma warning disable CS1591
    ChileContinental,
#pragma warning restore CS1591
    [EnumMember(Value = "Chile/EasterIsland")]
#pragma warning disable CS1591
    ChileEasterIsland,
#pragma warning restore CS1591
    [EnumMember(Value = "Cuba")]
#pragma warning disable CS1591
    Cuba,
#pragma warning restore CS1591
    [EnumMember(Value = "EET")]
#pragma warning disable CS1591
    EET,
#pragma warning restore CS1591
    [EnumMember(Value = "EST")]
#pragma warning disable CS1591
    EST,
#pragma warning restore CS1591
    [EnumMember(Value = "EST5EDT")]
#pragma warning disable CS1591
    EST5EDT,
#pragma warning restore CS1591
    [EnumMember(Value = "Egypt")]
#pragma warning disable CS1591
    Egypt,
#pragma warning restore CS1591
    [EnumMember(Value = "Eire")]
#pragma warning disable CS1591
    Eire,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT")]
#pragma warning disable CS1591
    EtcGMT,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+0")]
#pragma warning disable CS1591
    EtcGMT_plus_0,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+1")]
#pragma warning disable CS1591
    EtcGMT_plus_1,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+10")]
#pragma warning disable CS1591
    EtcGMT_plus_10,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+11")]
#pragma warning disable CS1591
    EtcGMT_plus_11,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+12")]
#pragma warning disable CS1591
    EtcGMT_plus_12,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+2")]
#pragma warning disable CS1591
    EtcGMT_plus_2,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+3")]
#pragma warning disable CS1591
    EtcGMT_plus_3,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+4")]
#pragma warning disable CS1591
    EtcGMT_plus_4,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+5")]
#pragma warning disable CS1591
    EtcGMT_plus_5,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+6")]
#pragma warning disable CS1591
    EtcGMT_plus_6,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+7")]
#pragma warning disable CS1591
    EtcGMT_plus_7,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+8")]
#pragma warning disable CS1591
    EtcGMT_plus_8,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT+9")]
#pragma warning disable CS1591
    EtcGMT_plus_9,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-0")]
#pragma warning disable CS1591
    EtcGMT0,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-1")]
#pragma warning disable CS1591
    EtcGMT1,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-10")]
#pragma warning disable CS1591
    EtcGMT10,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-11")]
#pragma warning disable CS1591
    EtcGMT11,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-12")]
#pragma warning disable CS1591
    EtcGMT12,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-13")]
#pragma warning disable CS1591
    EtcGMT13,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-14")]
#pragma warning disable CS1591
    EtcGMT14,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-2")]
#pragma warning disable CS1591
    EtcGMT2,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-3")]
#pragma warning disable CS1591
    EtcGMT3,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-4")]
#pragma warning disable CS1591
    EtcGMT4,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-5")]
#pragma warning disable CS1591
    EtcGMT5,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-6")]
#pragma warning disable CS1591
    EtcGMT6,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-7")]
#pragma warning disable CS1591
    EtcGMT7,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-8")]
#pragma warning disable CS1591
    EtcGMT8,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/GMT-9")]
#pragma warning disable CS1591
    EtcGMT9,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/Greenwich")]
#pragma warning disable CS1591
    EtcGreenwich,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/UCT")]
#pragma warning disable CS1591
    EtcUCT,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/UTC")]
#pragma warning disable CS1591
    EtcUTC,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/Universal")]
#pragma warning disable CS1591
    EtcUniversal,
#pragma warning restore CS1591
    [EnumMember(Value = "Etc/Zulu")]
#pragma warning disable CS1591
    EtcZulu,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Amsterdam")]
#pragma warning disable CS1591
    EuropeAmsterdam,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Andorra")]
#pragma warning disable CS1591
    EuropeAndorra,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Astrakhan")]
#pragma warning disable CS1591
    EuropeAstrakhan,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Athens")]
#pragma warning disable CS1591
    EuropeAthens,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Belfast")]
#pragma warning disable CS1591
    EuropeBelfast,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Belgrade")]
#pragma warning disable CS1591
    EuropeBelgrade,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Berlin")]
#pragma warning disable CS1591
    EuropeBerlin,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Bratislava")]
#pragma warning disable CS1591
    EuropeBratislava,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Brussels")]
#pragma warning disable CS1591
    EuropeBrussels,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Bucharest")]
#pragma warning disable CS1591
    EuropeBucharest,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Budapest")]
#pragma warning disable CS1591
    EuropeBudapest,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Busingen")]
#pragma warning disable CS1591
    EuropeBusingen,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Chisinau")]
#pragma warning disable CS1591
    EuropeChisinau,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Copenhagen")]
#pragma warning disable CS1591
    EuropeCopenhagen,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Dublin")]
#pragma warning disable CS1591
    EuropeDublin,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Gibraltar")]
#pragma warning disable CS1591
    EuropeGibraltar,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Guernsey")]
#pragma warning disable CS1591
    EuropeGuernsey,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Helsinki")]
#pragma warning disable CS1591
    EuropeHelsinki,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Isle_of_Man")]
#pragma warning disable CS1591
    EuropeIsle_of_Man,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Istanbul")]
#pragma warning disable CS1591
    EuropeIstanbul,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Jersey")]
#pragma warning disable CS1591
    EuropeJersey,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Kaliningrad")]
#pragma warning disable CS1591
    EuropeKaliningrad,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Kiev")]
#pragma warning disable CS1591
    EuropeKiev,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Kirov")]
#pragma warning disable CS1591
    EuropeKirov,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Lisbon")]
#pragma warning disable CS1591
    EuropeLisbon,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Ljubljana")]
#pragma warning disable CS1591
    EuropeLjubljana,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/London")]
#pragma warning disable CS1591
    EuropeLondon,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Luxembourg")]
#pragma warning disable CS1591
    EuropeLuxembourg,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Madrid")]
#pragma warning disable CS1591
    EuropeMadrid,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Malta")]
#pragma warning disable CS1591
    EuropeMalta,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Mariehamn")]
#pragma warning disable CS1591
    EuropeMariehamn,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Minsk")]
#pragma warning disable CS1591
    EuropeMinsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Monaco")]
#pragma warning disable CS1591
    EuropeMonaco,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Moscow")]
#pragma warning disable CS1591
    EuropeMoscow,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Nicosia")]
#pragma warning disable CS1591
    EuropeNicosia,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Oslo")]
#pragma warning disable CS1591
    EuropeOslo,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Paris")]
#pragma warning disable CS1591
    EuropeParis,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Podgorica")]
#pragma warning disable CS1591
    EuropePodgorica,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Prague")]
#pragma warning disable CS1591
    EuropePrague,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Riga")]
#pragma warning disable CS1591
    EuropeRiga,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Rome")]
#pragma warning disable CS1591
    EuropeRome,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Samara")]
#pragma warning disable CS1591
    EuropeSamara,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/San_Marino")]
#pragma warning disable CS1591
    EuropeSan_Marino,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Sarajevo")]
#pragma warning disable CS1591
    EuropeSarajevo,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Saratov")]
#pragma warning disable CS1591
    EuropeSaratov,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Simferopol")]
#pragma warning disable CS1591
    EuropeSimferopol,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Skopje")]
#pragma warning disable CS1591
    EuropeSkopje,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Sofia")]
#pragma warning disable CS1591
    EuropeSofia,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Stockholm")]
#pragma warning disable CS1591
    EuropeStockholm,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Tallinn")]
#pragma warning disable CS1591
    EuropeTallinn,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Tirane")]
#pragma warning disable CS1591
    EuropeTirane,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Tiraspol")]
#pragma warning disable CS1591
    EuropeTiraspol,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Ulyanovsk")]
#pragma warning disable CS1591
    EuropeUlyanovsk,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Uzhgorod")]
#pragma warning disable CS1591
    EuropeUzhgorod,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Vaduz")]
#pragma warning disable CS1591
    EuropeVaduz,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Vatican")]
#pragma warning disable CS1591
    EuropeVatican,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Vienna")]
#pragma warning disable CS1591
    EuropeVienna,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Vilnius")]
#pragma warning disable CS1591
    EuropeVilnius,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Volgograd")]
#pragma warning disable CS1591
    EuropeVolgograd,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Warsaw")]
#pragma warning disable CS1591
    EuropeWarsaw,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Zagreb")]
#pragma warning disable CS1591
    EuropeZagreb,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Zaporozhye")]
#pragma warning disable CS1591
    EuropeZaporozhye,
#pragma warning restore CS1591
    [EnumMember(Value = "Europe/Zurich")]
#pragma warning disable CS1591
    EuropeZurich,
#pragma warning restore CS1591
    [EnumMember(Value = "GB")]
#pragma warning disable CS1591
    GB,
#pragma warning restore CS1591
    [EnumMember(Value = "GB-Eire")]
#pragma warning disable CS1591
    GBEire,
#pragma warning restore CS1591
    [EnumMember(Value = "GMT")]
#pragma warning disable CS1591
    GMT,
#pragma warning restore CS1591
    [EnumMember(Value = "GMT+0")]
#pragma warning disable CS1591
    GMT_plus_0,
#pragma warning restore CS1591
    [EnumMember(Value = "GMT-0")]
#pragma warning disable CS1591
    GMT0,
#pragma warning restore CS1591
    [EnumMember(Value = "Greenwich")]
#pragma warning disable CS1591
    Greenwich,
#pragma warning restore CS1591
    [EnumMember(Value = "HST")]
#pragma warning disable CS1591
    HST,
#pragma warning restore CS1591
    [EnumMember(Value = "Hongkong")]
#pragma warning disable CS1591
    Hongkong,
#pragma warning restore CS1591
    [EnumMember(Value = "Iceland")]
#pragma warning disable CS1591
    Iceland,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Antananarivo")]
#pragma warning disable CS1591
    IndianAntananarivo,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Chagos")]
#pragma warning disable CS1591
    IndianChagos,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Christmas")]
#pragma warning disable CS1591
    IndianChristmas,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Cocos")]
#pragma warning disable CS1591
    IndianCocos,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Comoro")]
#pragma warning disable CS1591
    IndianComoro,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Kerguelen")]
#pragma warning disable CS1591
    IndianKerguelen,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Mahe")]
#pragma warning disable CS1591
    IndianMahe,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Maldives")]
#pragma warning disable CS1591
    IndianMaldives,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Mauritius")]
#pragma warning disable CS1591
    IndianMauritius,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Mayotte")]
#pragma warning disable CS1591
    IndianMayotte,
#pragma warning restore CS1591
    [EnumMember(Value = "Indian/Reunion")]
#pragma warning disable CS1591
    IndianReunion,
#pragma warning restore CS1591
    [EnumMember(Value = "Iran")]
#pragma warning disable CS1591
    Iran,
#pragma warning restore CS1591
    [EnumMember(Value = "Israel")]
#pragma warning disable CS1591
    Israel,
#pragma warning restore CS1591
    [EnumMember(Value = "Jamaica")]
#pragma warning disable CS1591
    Jamaica,
#pragma warning restore CS1591
    [EnumMember(Value = "Japan")]
#pragma warning disable CS1591
    Japan,
#pragma warning restore CS1591
    [EnumMember(Value = "Kwajalein")]
#pragma warning disable CS1591
    Kwajalein,
#pragma warning restore CS1591
    [EnumMember(Value = "Libya")]
#pragma warning disable CS1591
    Libya,
#pragma warning restore CS1591
    [EnumMember(Value = "MET")]
#pragma warning disable CS1591
    MET,
#pragma warning restore CS1591
    [EnumMember(Value = "MST")]
#pragma warning disable CS1591
    MST,
#pragma warning restore CS1591
    [EnumMember(Value = "MST7MDT")]
#pragma warning disable CS1591
    MST7MDT,
#pragma warning restore CS1591
    [EnumMember(Value = "Mexico/BajaNorte")]
#pragma warning disable CS1591
    MexicoBajaNorte,
#pragma warning restore CS1591
    [EnumMember(Value = "Mexico/BajaSur")]
#pragma warning disable CS1591
    MexicoBajaSur,
#pragma warning restore CS1591
    [EnumMember(Value = "Mexico/General")]
#pragma warning disable CS1591
    MexicoGeneral,
#pragma warning restore CS1591
    [EnumMember(Value = "NZ")]
#pragma warning disable CS1591
    NZ,
#pragma warning restore CS1591
    [EnumMember(Value = "NZ-CHAT")]
#pragma warning disable CS1591
    NZCHAT,
#pragma warning restore CS1591
    [EnumMember(Value = "Navajo")]
#pragma warning disable CS1591
    Navajo,
#pragma warning restore CS1591
    [EnumMember(Value = "PRC")]
#pragma warning disable CS1591
    PRC,
#pragma warning restore CS1591
    [EnumMember(Value = "PST8PDT")]
#pragma warning disable CS1591
    PST8PDT,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Apia")]
#pragma warning disable CS1591
    PacificApia,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Auckland")]
#pragma warning disable CS1591
    PacificAuckland,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Bougainville")]
#pragma warning disable CS1591
    PacificBougainville,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Chatham")]
#pragma warning disable CS1591
    PacificChatham,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Chuuk")]
#pragma warning disable CS1591
    PacificChuuk,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Easter")]
#pragma warning disable CS1591
    PacificEaster,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Efate")]
#pragma warning disable CS1591
    PacificEfate,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Enderbury")]
#pragma warning disable CS1591
    PacificEnderbury,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Fakaofo")]
#pragma warning disable CS1591
    PacificFakaofo,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Fiji")]
#pragma warning disable CS1591
    PacificFiji,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Funafuti")]
#pragma warning disable CS1591
    PacificFunafuti,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Galapagos")]
#pragma warning disable CS1591
    PacificGalapagos,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Gambier")]
#pragma warning disable CS1591
    PacificGambier,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Guadalcanal")]
#pragma warning disable CS1591
    PacificGuadalcanal,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Guam")]
#pragma warning disable CS1591
    PacificGuam,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Honolulu")]
#pragma warning disable CS1591
    PacificHonolulu,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Johnston")]
#pragma warning disable CS1591
    PacificJohnston,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Kanton")]
#pragma warning disable CS1591
    PacificKanton,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Kiritimati")]
#pragma warning disable CS1591
    PacificKiritimati,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Kosrae")]
#pragma warning disable CS1591
    PacificKosrae,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Kwajalein")]
#pragma warning disable CS1591
    PacificKwajalein,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Majuro")]
#pragma warning disable CS1591
    PacificMajuro,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Marquesas")]
#pragma warning disable CS1591
    PacificMarquesas,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Midway")]
#pragma warning disable CS1591
    PacificMidway,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Nauru")]
#pragma warning disable CS1591
    PacificNauru,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Niue")]
#pragma warning disable CS1591
    PacificNiue,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Norfolk")]
#pragma warning disable CS1591
    PacificNorfolk,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Noumea")]
#pragma warning disable CS1591
    PacificNoumea,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Pago_Pago")]
#pragma warning disable CS1591
    PacificPago_Pago,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Palau")]
#pragma warning disable CS1591
    PacificPalau,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Pitcairn")]
#pragma warning disable CS1591
    PacificPitcairn,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Pohnpei")]
#pragma warning disable CS1591
    PacificPohnpei,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Ponape")]
#pragma warning disable CS1591
    PacificPonape,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Port_Moresby")]
#pragma warning disable CS1591
    PacificPort_Moresby,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Rarotonga")]
#pragma warning disable CS1591
    PacificRarotonga,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Saipan")]
#pragma warning disable CS1591
    PacificSaipan,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Samoa")]
#pragma warning disable CS1591
    PacificSamoa,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Tahiti")]
#pragma warning disable CS1591
    PacificTahiti,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Tarawa")]
#pragma warning disable CS1591
    PacificTarawa,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Tongatapu")]
#pragma warning disable CS1591
    PacificTongatapu,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Truk")]
#pragma warning disable CS1591
    PacificTruk,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Wake")]
#pragma warning disable CS1591
    PacificWake,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Wallis")]
#pragma warning disable CS1591
    PacificWallis,
#pragma warning restore CS1591
    [EnumMember(Value = "Pacific/Yap")]
#pragma warning disable CS1591
    PacificYap,
#pragma warning restore CS1591
    [EnumMember(Value = "Poland")]
#pragma warning disable CS1591
    Poland,
#pragma warning restore CS1591
    [EnumMember(Value = "Portugal")]
#pragma warning disable CS1591
    Portugal,
#pragma warning restore CS1591
    [EnumMember(Value = "ROC")]
#pragma warning disable CS1591
    ROC,
#pragma warning restore CS1591
    [EnumMember(Value = "ROK")]
#pragma warning disable CS1591
    ROK,
#pragma warning restore CS1591
    [EnumMember(Value = "Singapore")]
#pragma warning disable CS1591
    Singapore,
#pragma warning restore CS1591
    [EnumMember(Value = "Turkey")]
#pragma warning disable CS1591
    Turkey,
#pragma warning restore CS1591
    [EnumMember(Value = "UCT")]
#pragma warning disable CS1591
    UCT,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Alaska")]
#pragma warning disable CS1591
    USAlaska,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Aleutian")]
#pragma warning disable CS1591
    USAleutian,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Arizona")]
#pragma warning disable CS1591
    USArizona,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Central")]
#pragma warning disable CS1591
    USCentral,
#pragma warning restore CS1591
    [EnumMember(Value = "US/East-Indiana")]
#pragma warning disable CS1591
    USEastIndiana,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Eastern")]
#pragma warning disable CS1591
    USEastern,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Hawaii")]
#pragma warning disable CS1591
    USHawaii,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Indiana-Starke")]
#pragma warning disable CS1591
    USIndianaStarke,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Michigan")]
#pragma warning disable CS1591
    USMichigan,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Mountain")]
#pragma warning disable CS1591
    USMountain,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Pacific")]
#pragma warning disable CS1591
    USPacific,
#pragma warning restore CS1591
    [EnumMember(Value = "US/Samoa")]
#pragma warning disable CS1591
    USSamoa,
#pragma warning restore CS1591
    [EnumMember(Value = "UTC")]
#pragma warning disable CS1591
    UTC,
#pragma warning restore CS1591
    [EnumMember(Value = "Universal")]
#pragma warning disable CS1591
    Universal,
#pragma warning restore CS1591
    [EnumMember(Value = "W-SU")]
#pragma warning disable CS1591
    WSU,
#pragma warning restore CS1591
    [EnumMember(Value = "WET")]
#pragma warning disable CS1591
    WET,
#pragma warning restore CS1591
    [EnumMember(Value = "Zulu")]
#pragma warning disable CS1591
    Zulu,
#pragma warning restore CS1591
}
