namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1996 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public En1996Part Part { get; set; } = En1996Part.Part1_1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1996() { }

        public En1996(En1996Part part, NationalAnnex nationalAnnex)
        {
            Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1996" + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = "Eurocode 6: Design of Masonry Structures";
            string part = En1996Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
