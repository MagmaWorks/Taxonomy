using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1994 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code => Eurocode.EN1994;
        public Enum Part => EN1994Part;
        public NationalAnnex NationalAnnex { get; set; }
        public string Title => GetTitle();

        private EN1994Part EN1994Part;

        public EN1994(EN1994Part part, NationalAnnex nationalAnnex) {
            EN1994Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            string part = EN1994Utility.GetPartDescription(EN1994Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
