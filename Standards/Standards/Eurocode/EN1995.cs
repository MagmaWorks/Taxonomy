namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1995 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Eurocode Code { get; } = Eurocode.EN1995;
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
            string codeNo = Code.ToString().Replace("EN", "EN ")
                + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = EurocodeUtility.GetCodeTitle(Code);
            string part = En1995Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
