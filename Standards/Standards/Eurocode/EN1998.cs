using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1998 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code { get; } = Eurocode.EN1998;
        public Enum Part => EN1998Part;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();
        private EN1998Part EN1998Part = EN1998Part.Part1;

        public EN1998() { }

        public EN1998(EN1998Part part, NationalAnnex nationalAnnex)
        {
            EN1998Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            string part = EN1998Utility.GetPartDescription(EN1998Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
