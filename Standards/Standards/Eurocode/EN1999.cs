using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1999 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code => Eurocode.EN1999;
        public Enum Part => EN1999Part;
        public NationalAnnex NationalAnnex { get; set; }
        public string Title => GetTitle();

        private EN1999Part EN1999Part;

        public EN1999(EN1999Part part, NationalAnnex nationalAnnex) {
            EN1999Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            string part = EN1999Utility.GetPartDescription(EN1999Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
