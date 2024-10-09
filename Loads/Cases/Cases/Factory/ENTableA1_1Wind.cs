using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    internal class ENTableA1_1Wind : ITableA1_1
    {
        public TableA1_1Properties GetProperties(NationalAnnex nationalAnnex)
        {
            if (!EN1990_TableA1_1_Wind.TryGetValue(nationalAnnex, out TableA1_1Properties factors))
            {
                throw new System.NotImplementedException(
                    $"NA {nationalAnnex} not implemented for EN1990 Table A1.1 Wind φ-factors");
            };

            return factors;
        }

        private static readonly Dictionary<NationalAnnex, TableA1_1Properties> EN1990_TableA1_1_Wind = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1_1Properties(0.6, 0.2, 0.0) },
            { NationalAnnex.UnitedKingdom, new TableA1_1Properties(0.6, 0.2, 0.0) },
            { NationalAnnex.Germany, new TableA1_1Properties(0.6, 0.2, 0.0) },
        };
    }
}
