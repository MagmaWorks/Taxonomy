namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1997 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public En1997Part Part { get; set; } = En1997Part.Part1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1997() { }

        public En1997(En1997Part part, NationalAnnex nationalAnnex)
        {
            Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1997" + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = "Eurocode 7: Geotechnical Design";
            string part = En1997Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
