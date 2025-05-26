namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1992 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public En1992Part Part { get; set; } = En1992Part.Part1_1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1992() { }

        public En1992(En1992Part part, NationalAnnex nationalAnnex)
        {
            Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1992" + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = "Eurocode 2: Design of Concrete Structures";
            string part = En1992Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
