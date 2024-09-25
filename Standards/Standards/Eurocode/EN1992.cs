using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1992 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code { get; } = Eurocode.EN1992;
        public Enum Part => EN1992Part;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();
        private EN1992Part EN1992Part = EN1992Part.Part1_1;

        public EN1992() { }

        public EN1992(EN1992Part part, NationalAnnex nationalAnnex)
        {
            EN1992Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            string part = EN1992Utility.GetPartDescription(EN1992Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
