using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1995 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code { get; } = Eurocode.EN1995;
        public Enum Part => EN1995Part;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();
        private EN1995Part EN1995Part = EN1995Part.Part1_1;

        public EN1995() { }

        public EN1995(EN1995Part part, NationalAnnex nationalAnnex)
        {
            EN1995Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            string part = EN1995Utility.GetPartDescription(EN1995Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
