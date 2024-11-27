using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1995 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Eurocode Code { get; } = Eurocode.EN1995;
        public EN1995Part Part { get; set; } = EN1995Part.Part1_1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public EN1995() { }

        public EN1995(EN1995Part part, NationalAnnex nationalAnnex)
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
            string part = EN1995Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
