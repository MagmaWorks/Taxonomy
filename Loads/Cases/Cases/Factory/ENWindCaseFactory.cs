using System.Collections.Generic;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public static partial class ENLoadCaseFactory
    {
        private static readonly Dictionary<NationalAnnex, TableA1Properties> EN1990_TableA1_1_Wind = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1Properties(0.6, 0.2, 0.0) },
            { NationalAnnex.UnitedKingdom, new TableA1Properties(0.6, 0.2, 0.0) },
            { NationalAnnex.Germany, new TableA1Properties(0.6, 0.2, 0.0) },
        };

        public static VariableCase CreateWind(NationalAnnex nationalAnnex)
        {
            if (!EN1990_TableA1_1_Wind.TryGetValue(nationalAnnex, out TableA1Properties factors))
            {
                throw new System.NotImplementedException($"NA {nationalAnnex} not implemented for EN1990 Table A1.1 Wind φ-factors");
            };

            return new VariableCase()
            {
                Characteristic = factors.Phi_0,
                Frequent = factors.Phi_1,
                QuasiPermanent = factors.Phi_2,
                Name = $"Wind loads",
                Nickname = "W",
            };
        }

        public static VariableCase CreateWind(IList<ILoad> loads, NationalAnnex nationalAnnex)
        {
            VariableCase loadCase = CreateWind(nationalAnnex);
            loadCase.Loads = loads;
            return loadCase;
        }
    }
}
