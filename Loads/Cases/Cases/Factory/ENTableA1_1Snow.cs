using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    internal class ENTableA1_1Snow : ITableA1_1Snow
    {
        public TableA1_1Properties GetProperties(bool above1000m, NationalAnnex nationalAnnex)
        {
            if (!EN1990_TableA1_1_Snow.TryGetValue(
                nationalAnnex, out (TableA1_1Properties Above1000m, TableA1_1Properties Below1000m) kvp))
            {
                throw new System.NotImplementedException(
                    $"NA {nationalAnnex} not implemented for EN1990 Table A1.1 Snow φ-factors");
            }
            ;

            return above1000m ? kvp.Above1000m : kvp.Below1000m;
        }

        private static readonly Dictionary<NationalAnnex,
            (TableA1_1Properties Above1000m, TableA1_1Properties Below1000m)> EN1990_TableA1_1_Snow = new()
        {
            { NationalAnnex.RecommendedValues,
                    (new TableA1_1Properties(0.7, 0.5, 0.2), new TableA1_1Properties(0.5, 0.2, 0.0)) },
            { NationalAnnex.UnitedKingdom,
                    (new TableA1_1Properties(0.7, 0.5, 0.2), new TableA1_1Properties(0.5, 0.2, 0.0)) },
            { NationalAnnex.Germany,
                    (new TableA1_1Properties(0.7, 0.5, 0.2), new TableA1_1Properties(0.5, 0.2, 0.0)) },
        };
    }
}
