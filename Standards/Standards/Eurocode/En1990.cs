namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1990 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1990() { }

        public En1990(NationalAnnex nationalAnnex)
        {
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1990";
            string name = "Eurocode - Basis of Structural Design";
            return $"{prefix} {codeNo}: {name}".TrimStart(' ');
        }
    }
}
