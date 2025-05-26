namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1994 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public En1994Part Part { get; set; } = En1994Part.Part1_1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1994() { }

        public En1994(En1994Part part, NationalAnnex nationalAnnex)
        {
            Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1994" + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = "Eurocode 4: Design of Composite Steel & Concrete Structures";
            string part = En1994Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
