namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1993 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public En1993Part Part { get; set; } = En1993Part.Part1_1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1993() { }

        public En1993(En1993Part part, NationalAnnex nationalAnnex)
        {
            Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1993" + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = "Eurocode 3: Design of Steel Structures";
            string part = En1993Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
