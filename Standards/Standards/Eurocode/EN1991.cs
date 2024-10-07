using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1991 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code { get; } = Eurocode.EN1991;
        public Enum Part => EN1991Part;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();
        private EN1991Part EN1991Part = EN1991Part.Part1_1;

        public EN1991() { }

        public EN1991(EN1991Part part, NationalAnnex nationalAnnex)
        {
            EN1991Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            string part = EN1991Utility.GetPartDescription(EN1991Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
