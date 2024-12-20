﻿namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class En1990 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Eurocode Code { get; } = Eurocode.EN1990;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();

        public En1990() { }

        public En1990(NationalAnnex nationalAnnex)
        {
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = Code.ToString().Replace("EN", "EN ");
            string name = EurocodeUtility.GetCodeTitle(Code);
            return $"{prefix} {codeNo}: {name}".TrimStart(' ');
        }
    }
}
