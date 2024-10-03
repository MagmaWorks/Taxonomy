using System.Collections.Generic;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public static partial class ENLoadCaseFactory
    {
        private static readonly Dictionary<NationalAnnex, TableA1Properties> EN1990_TableA1_1_Thermal = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1Properties(0.6, 0.5, 0.0) },
            { NationalAnnex.UnitedKingdom, new TableA1Properties(0.6, 0.5, 0.0) },
            { NationalAnnex.Germany, new TableA1Properties(0.6, 0.5, 0.0) },
        };

        public static VariableCase CreateThermal(NationalAnnex nationalAnnex)
        {
            if (!EN1990_TableA1_1_Thermal.TryGetValue(nationalAnnex, out TableA1Properties factors))
            {
                throw new System.NotImplementedException($"NA {nationalAnnex} not implemented for EN1990 Table A1.1 Thermal φ-factors");
            };

            return new VariableCase()
            {
                Characteristic = factors.Phi_0,
                Frequent = factors.Phi_1,
                QuasiPermanent = factors.Phi_2,
                Name = $"Thermal loads",
                Nickname = "T",
            };
        }

        public static VariableCase CreateThermal(IList<ILoad> loads, NationalAnnex nationalAnnex)
        {
            VariableCase loadCase = CreateThermal(nationalAnnex);
            loadCase.Loads = loads;
            return loadCase;
        }
    }
}
