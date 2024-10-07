using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public static partial class ENLoadCaseFactory
    {
        private struct TableA1Properties
        {
            internal Ratio Phi_0;
            internal Ratio Phi_1;
            internal Ratio Phi_2;

            internal TableA1Properties(double phi_0, double phi_1, double phi_2)
            {
                RatioUnit unit = RatioUnit.DecimalFraction;
                Phi_0 = new Ratio(phi_0, unit);
                Phi_1 = new Ratio(phi_1, unit);
                Phi_2 = new Ratio(phi_2, unit);
            }
        }

        private static readonly Dictionary<NationalAnnex, Dictionary<ImposedLoadCategory, TableA1Properties>> EN1990_TableA1_1_Imposed = new()
        {
            { NationalAnnex.RecommendedValues, new () {
                { ImposedLoadCategory.CategoryA, new TableA1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryB, new TableA1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryC, new TableA1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryD, new TableA1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryE, new TableA1Properties(1.0, 0.9, 0.8) },
                { ImposedLoadCategory.CategoryF, new TableA1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryG, new TableA1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryH, new TableA1Properties(0.0, 0.0, 0.0) },
                }
            },
            { NationalAnnex.UnitedKingdom, new () {
                { ImposedLoadCategory.CategoryA, new TableA1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryB, new TableA1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryC, new TableA1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryD, new TableA1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryE, new TableA1Properties(1.0, 0.9, 0.8) },
                { ImposedLoadCategory.CategoryF, new TableA1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryG, new TableA1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryH, new TableA1Properties(0.7, 0.0, 0.0) },
                }
            },
            { NationalAnnex.Germany, new () {
                { ImposedLoadCategory.CategoryA, new TableA1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryB, new TableA1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryC, new TableA1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryD, new TableA1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryE, new TableA1Properties(1.0, 0.9, 0.8) },
                { ImposedLoadCategory.CategoryF, new TableA1Properties(0.7, 0.7, 0.6) },
                { ImposedLoadCategory.CategoryG, new TableA1Properties(0.7, 0.5, 0.3) },
                { ImposedLoadCategory.CategoryH, new TableA1Properties(0.0, 0.0, 0.0) },
                }
            },
        };

        public static VariableCase CreateImposed(ImposedLoadCategory category, NationalAnnex nationalAnnex)
        {
            if (!EN1990_TableA1_1_Imposed.TryGetValue(nationalAnnex, out Dictionary<ImposedLoadCategory, TableA1Properties> kvp))
            {
                throw new System.NotImplementedException($"NA {nationalAnnex} not implemented for EN1990 Table A1.1 Imposed Load φ-factors");
            };

            TableA1Properties factors = kvp[category];
            return new VariableCase()
            {
                Characteristic = factors.Phi_0,
                Frequent = factors.Phi_1,
                QuasiPermanent = factors.Phi_2,
                Name = $"Live loads Category {category.ToString().Last()}",
                Nickname = $"Q",
            };
        }

        public static VariableCase CreateImposed(IList<ILoad> loads, ImposedLoadCategory category, NationalAnnex nationalAnnex)
        {
            VariableCase loadCase = CreateImposed(category, nationalAnnex);
            loadCase.Loads = loads;
            return loadCase;
        }
    }
}
