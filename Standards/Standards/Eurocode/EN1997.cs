using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1997 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Eurocode Code { get; } = Eurocode.EN1997;
        public EN1997Part Part { get; set; } = EN1997Part.Part1;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public EN1997() { }

        public EN1997(EN1997Part part, NationalAnnex nationalAnnex)
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
            string part = EN1997Utility.GetPartDescription(Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
