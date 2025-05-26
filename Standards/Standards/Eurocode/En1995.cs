namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1995 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public En1995Part Part { get; set; } = En1995Part.Part1_1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1995() { }

        public En1995(En1995Part part, NationalAnnex nationalAnnex)
        {
            Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1995" + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = "Eurocode 5: Design of Timber Structures";
            string part = En1995Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
