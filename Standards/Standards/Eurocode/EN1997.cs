using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1997 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code => Eurocode.EN1997;
        public Enum Part => EN1997Part;
        public NationalAnnex NationalAnnex { get; set; }
        public string Title => GetTitle();

        private EN1997Part EN1997Part;

        public EN1997(EN1997Part part, NationalAnnex nationalAnnex)
        {
            EN1997Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            string part = EN1997Utility.GetPartDescription(EN1997Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
