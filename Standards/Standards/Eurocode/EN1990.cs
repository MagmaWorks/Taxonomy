using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1990 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code { get; } = Eurocode.EN1990;
        public Enum Part => EN1990Part;
        public NationalAnnex NationalAnnex { get; set; }
        public string Title => GetTitle();

        private EN1990Part EN1990Part = EN1990Part.None;

        public EN1990()
        {
            Code = Eurocode.EN1990;
            NationalAnnex = NationalAnnex.RecommendedValues;
        }

        public EN1990(NationalAnnex nationalAnnex)
        {
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            return $"{prefix} {codeNo}: {name}".TrimStart(' ');
        }
    }
}
