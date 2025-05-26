namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1998 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public En1998Part Part { get; set; } = En1998Part.Part1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1998() { }

        public En1998(En1998Part part, NationalAnnex nationalAnnex)
        {
            Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1998" + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = "Eurocode 8: Design of Structures for Earthquake Resistance";
            string part = En1998Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
