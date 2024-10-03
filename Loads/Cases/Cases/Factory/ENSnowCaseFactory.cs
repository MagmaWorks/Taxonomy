using System.Collections.Generic;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public static partial class ENLoadCaseFactory
    {
        private static readonly Dictionary<NationalAnnex, (TableA1Properties Above1000m, TableA1Properties Below1000m)> EN1990_TableA1_1_Snow = new()
        {
            { NationalAnnex.RecommendedValues, (new TableA1Properties(0.7, 0.5, 0.2), new TableA1Properties(0.5, 0.2, 0.0)) },
            { NationalAnnex.UnitedKingdom, (new TableA1Properties(0.7, 0.5, 0.2), new TableA1Properties(0.5, 0.2, 0.0)) },
            { NationalAnnex.Germany, (new TableA1Properties(0.7, 0.5, 0.2), new TableA1Properties(0.5, 0.2, 0.0)) },
        };

        public static VariableCase CreateSnow(NationalAnnex nationalAnnex, bool altitudeAbove1000m)
        {
            if (!EN1990_TableA1_1_Snow.TryGetValue(nationalAnnex, out (TableA1Properties Above1000m, TableA1Properties Below1000m) kvp))
            {
                throw new System.NotImplementedException($"NA {nationalAnnex} not implemented for EN1990 Table A1.1 Snow φ-factors");
            };

            TableA1Properties factors = altitudeAbove1000m ? kvp.Above1000m : kvp.Below1000m;
            return new VariableCase()
            {
                Characteristic = factors.Phi_0,
                Frequent = factors.Phi_1,
                QuasiPermanent = factors.Phi_2,
                Name = $"Snow loads",
                Nickname = "S",
            };
        }

        public static VariableCase CreateSnow(IList<ILoad> loads, NationalAnnex nationalAnnex, bool altitudeAbove1000m)
        {
            VariableCase loadCase = CreateSnow(nationalAnnex, altitudeAbove1000m);
            loadCase.Loads = loads;
            return loadCase;
        }
    }
}
