﻿using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public class EN1996 : IEurocode
    {
        public StandardBody Body => StandardBody.EN;
        public Enum Code { get; } = Eurocode.EN1996;
        public Enum Part => EN1996Part;
        public NationalAnnex NationalAnnex { get; set; } = NationalAnnex.RecommendedValues;
        public string Title => GetTitle();
        private EN1996Part EN1996Part = EN1996Part.Part1_1;

        public EN1996() { }

        public EN1996(EN1996Part part, NationalAnnex nationalAnnex)
        {
            EN1996Part = part;
            NationalAnnex = nationalAnnex;
        }

        private string GetTitle()
        {
            string prefix = NationalAnnexUtility.GetAbbreviation(NationalAnnex);
            string codeNo = EurocodeUtility.GetCodeNumber(this);
            string name = EurocodeUtility.GetCodeTitle((Eurocode)Code);
            string part = EN1996Utility.GetPartDescription(EN1996Part);
            return $"{prefix} {codeNo}: {name} - {part}".TrimStart(' ');
        }
    }
}
