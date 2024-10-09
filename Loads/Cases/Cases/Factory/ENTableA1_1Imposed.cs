using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    internal class ENTableA1_1Imposed : ITableA1_1Imposed
    {
        public TableA1_1Properties GetProperties(ImposedLoadCategory category, NationalAnnex nationalAnnex)
        {
            if (!EN1990_TableA1_1_Imposed.TryGetValue(
                nationalAnnex, out Dictionary<ImposedLoadCategory, TableA1_1Properties> kvp))
            {
                throw new System.NotImplementedException(
                    $"NA {nationalAnnex} not implemented for EN1990 Table A1.1 Imposed Load φ-factors");
            };

            return kvp[category];
        }

        private static readonly Dictionary<NationalAnnex,
            Dictionary<ImposedLoadCategory, TableA1_1Properties>> EN1990_TableA1_1_Imposed = new()
        {
            { NationalAnnex.RecommendedValues, new () {
                { ImposedLoadCategory.CategoryA, new TableA1_1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryB, new TableA1_1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryC, new TableA1_1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryD, new TableA1_1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryE, new TableA1_1Properties(1.0, 0.9, 0.8) },
                { ImposedLoadCategory.CategoryF, new TableA1_1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryG, new TableA1_1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryH, new TableA1_1Properties(0.0, 0.0, 0.0) },
                }
            },
            { NationalAnnex.UnitedKingdom, new () {
                { ImposedLoadCategory.CategoryA, new TableA1_1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryB, new TableA1_1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryC, new TableA1_1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryD, new TableA1_1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryE, new TableA1_1Properties(1.0, 0.9, 0.8) },
                { ImposedLoadCategory.CategoryF, new TableA1_1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryG, new TableA1_1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryH, new TableA1_1Properties(0.7, 0.0, 0.0) },
                }
            },
            { NationalAnnex.Germany, new () {
                { ImposedLoadCategory.CategoryA, new TableA1_1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryB, new TableA1_1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryC, new TableA1_1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryD, new TableA1_1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryE, new TableA1_1Properties(1.0, 0.9, 0.8) },
                { ImposedLoadCategory.CategoryF, new TableA1_1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryG, new TableA1_1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryH, new TableA1_1Properties(0.0, 0.0, 0.0) },
                }
            },
        };
    }
}
