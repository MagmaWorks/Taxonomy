using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1993 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code { get; } = Eurocode.EN1993;
        public Enum Part => EN1993Part;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();
        private EN1993Part EN1993Part = EN1993Part.Part1_1;

        public EN1993() { }

        public EN1993(EN1993Part part, NationalAnnex nationalAnnex)
        {
            EN1993Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            string part = EN1993Utility.GetPartDescription(EN1993Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
