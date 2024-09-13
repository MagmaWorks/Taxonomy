namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class NationalAnnexUtility
    {
        internal static string GetAbbreviation(NationalAnnex na)
        {
            return na switch
            {
                NationalAnnex.RecommendedValues => string.Empty,
                NationalAnnex.Austria => "ONORM",
                NationalAnnex.Belarus => "Ткп",
                NationalAnnex.Belgium => "NBN",
                NationalAnnex.BosniaAndHerzegovinia => "BAS",
                NationalAnnex.Bulgaria => "БДС",
                NationalAnnex.Cyprus => "CYS",
                NationalAnnex.CzechRepublic => "CSN",
                NationalAnnex.Denmark => "DS",
                NationalAnnex.Estonia => "EVS",
                NationalAnnex.Finland => "SFS",
                NationalAnnex.France => "NF",
                NationalAnnex.Germany => "DIN",
                NationalAnnex.Greece => "ΕΛΟΤ",
                NationalAnnex.Hungary => "MSZ",
                NationalAnnex.Iceland => "IST",
                NationalAnnex.Ireland => "IS",
                NationalAnnex.Italy => "UNI",
                NationalAnnex.Latvia => "LVS",
                NationalAnnex.Lithuania => "LST",
                NationalAnnex.Luxembourg => "ILNAS",
                NationalAnnex.Malta => "MSA",
                NationalAnnex.Netherlands => "NEN",
                NationalAnnex.NorthMacedonia => "MKC",
                NationalAnnex.Norway => "NS",
                NationalAnnex.Poland => "PN",
                NationalAnnex.Portugal => "NP",
                NationalAnnex.Romania => "SR",
                NationalAnnex.Serbia => "SRPS",
                NationalAnnex.Slovakia => "STN",
                NationalAnnex.Slovenia => "SIST",
                NationalAnnex.Spain => "UNE",
                NationalAnnex.Sweden => "BFS",
                NationalAnnex.Switzerland => "SN",
                NationalAnnex.Turkey => "TS",
                NationalAnnex.UnitedKingdom => "BS",
                NationalAnnex.Singapore => "SS",
                _ => throw new System.ArgumentException("Unknown National Annex"),
            };
        }
    }
}
