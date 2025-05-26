namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1991 : IStandard
    {
        public StandardBody Body => StandardBody.EN;
        public En1991Part Part { get; set; } = En1991Part.Part1_1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1991() { }

        public En1991(En1991Part part, NationalAnnex nationalAnnex)
        {
            Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = "EN 1991" + Part.ToString().Replace("Part", "-").Replace("_", "-");
            string name = "Eurocode 1: Actions on Structures";
            string part = En1991Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
