namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1999 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public En1999Part Part { get; set; } = En1999Part.Part1_1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1999() { }

        public En1999(En1999Part part, NationalAnnex nationalAnnex)
        {
            Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1999" + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = "Eurocode 9: Design of Aluminium Structures";
            string part = En1999Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
