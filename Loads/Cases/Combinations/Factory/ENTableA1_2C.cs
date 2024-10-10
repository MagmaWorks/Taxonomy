using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Combinations.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    internal class ENTableA1_2C : ITableA1_2
    {
        public TableA1_2Properties GetProperties(NationalAnnex nationalAnnex)
        {
            if (!EN1990_TableA1_2C.TryGetValue(nationalAnnex, out TableA1_2Properties factors))
            {
                throw new System.NotImplementedException(
                    $"NA {nationalAnnex} not implemented for EN1990 Table A1.2(C) values");
            };

            return factors;
        }

        private static readonly Dictionary<NationalAnnex, TableA1_2Properties> EN1990_TableA1_2C = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1_2Properties(1.0, 1.0, 1.3, 1.3) },
            { NationalAnnex.UnitedKingdom, new TableA1_2Properties(1.0, 1.0, 1.3, 1.3) },
        };
    }
}
