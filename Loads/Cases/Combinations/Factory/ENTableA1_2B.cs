using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Combinations.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    internal class ENTableA1_2B : ITableA1_2
    {
        public TableA1_2Properties GetProperties(NationalAnnex nationalAnnex)
        {
            if (!EN1990_TableA1_2B.TryGetValue(nationalAnnex, out TableA1_2Properties factors))
            {
                throw new System.NotImplementedException(
                    $"NA {nationalAnnex} not implemented for EN1990 Table A1.2(B) values");
            }
            ;

            return factors;
        }

        private static readonly Dictionary<NationalAnnex, TableA1_2Properties> EN1990_TableA1_2B = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1_2Properties(1.35, 1.0, 1.5, 1.5, 0.85) },
            { NationalAnnex.UnitedKingdom, new TableA1_2Properties(1.35, 1.0, 1.5, 1.5, 0.925) },
        };
    }
}
