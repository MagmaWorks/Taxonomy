using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public static partial class ENCombinationFactory
    {
        public static IList<IEquilibriumCombination> CreateEquSetA(IList<ILoadCase> cases)
        {
            return CreateEquSetA(cases, NationalAnnex.RecommendedValues);
        }

        public static IList<IEquilibriumCombination> CreateEquSetA(IList<ILoadCase> cases, NationalAnnex nationalAnnex, int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            if (!EN1990_TableA1_2A.TryGetValue(nationalAnnex, out TableA1Properties factors))
            {
                throw new System.NotImplementedException($"NA {nationalAnnex} not implemented for EN1990 Table A1.2(A) values");
            };

            var combinations = new List<IEquilibriumCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new EquilibriumCombination()
                {
                    Name = $"LC{firstCaseId++}: EQU Set A, Eq. 6.10 - Leading {variables[i].Name}",
                    PermanentCases = permanents,
                    PermanentPartialFactor = factors.Gamma_Gsup,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    LeadingVariablePartialFactor = factors.Gamma_Q1,
                    AccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    AccompanyingPartialFactor = factors.Gamma_Qi,
                });

                if (variables[i].IsHorizontal)
                {
                    combinations.Add(new EquilibriumCombination()
                    {
                        Name = $"LC{firstCaseId++}: EQU Set A, Eq. 6.10 - Leading {variables[i].Name} with unfavourable permanent",
                        PermanentCases = permanents.Where((item, index) => !item.IsFavourable).ToList(),
                        PermanentPartialFactor = factors.Gamma_Ginf,
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        LeadingVariablePartialFactor = factors.Gamma_Q1,
                        AccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                        AccompanyingPartialFactor = factors.Gamma_Qi,
                    });
                }
            }

            return combinations;
        }

        private static readonly Dictionary<NationalAnnex, TableA1Properties> EN1990_TableA1_2A = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1Properties(1.1, 0.9, 1.5, 1.5) },
            { NationalAnnex.UnitedKingdom, new TableA1Properties(1.1, 0.9, 1.5, 1.5) },

        };
    }
}
