using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Loads.Combinations.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public static partial class ENCombinationFactory
    {


        public static IList<IEquilibriumCombination> CreateEquSetA(IList<ILoadCase> cases)
        {
            return CreateEquSetA(cases, NationalAnnex.RecommendedValues);
        }

        public static IList<IEquilibriumCombination> CreateEquSetA(IList<ILoadCase> cases, NationalAnnex nationalAnnex, string prefix = "LC", int firstCaseId = 1)
        {
            TableA1_2Properties factors = new ENTableA1_2A().GetProperties(nationalAnnex);
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            var combinations = new List<IEquilibriumCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new EquilibriumCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: EQU Set A, Eq. 6.10 - Leading {variables[i].Name}",
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
                        Name = $"{prefix}{firstCaseId++}: EQU Set A, Eq. 6.10 - Leading {variables[i].Name} with unfavourable permanent",
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
    }
}
