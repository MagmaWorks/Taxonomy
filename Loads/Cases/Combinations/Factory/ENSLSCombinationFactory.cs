using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public static partial class ENCombinationFactory
    {
        public static IList<ICharacteristicCombination> CreateCharacteristic(IList<ILoadCase> cases, string prefix = "LC", int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            var combinations = new List<ICharacteristicCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new CharacteristicCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: SLS Characteristic - Leading {variables[i].Name}",
                    PermanentCases = permanents,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    AccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                });

                if (variables[i].IsHorizontal)
                {
                    combinations.Add(new CharacteristicCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: SLS Characteristic - Leading {variables[i].Name} with unfavourable permanent",
                        PermanentCases = permanents.Where((item, index) => !item.IsFavourable).ToList(),
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        AccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                    });
                }
            }

            return combinations;
        }

        public static IList<IFrequentCombination> CreateFrequent(IList<ILoadCase> cases, string prefix = "LC", int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            var combinations = new List<IFrequentCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new FrequentCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: SLS Frequent - Leading {variables[i].Name}",
                    PermanentCases = permanents,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    AccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                });

                if (variables[i].IsHorizontal)
                {
                    combinations.Add(new FrequentCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: SLS Frequent - Leading {variables[i].Name} with unfavourable permanent",
                        PermanentCases = permanents.Where((item, index) => !item.IsFavourable).ToList(),
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        AccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                    });
                }
            }

            return combinations;
        }

        public static IList<IQuasiPermanentCombination> CreateQuasiPermanent(IList<ILoadCase> cases, string prefix = "LC", int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            var combinations = new List<IQuasiPermanentCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new QuasiPermanentCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: SLS Quasi-permanent - Leading {variables[i].Name}",
                    PermanentCases = permanents,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    AccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                });

                if (variables[i].IsHorizontal)
                {
                    combinations.Add(new QuasiPermanentCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: SLS Quasi-permanent - Leading {variables[i].Name} with unfavourable permanent",
                        PermanentCases = permanents.Where((item, index) => !item.IsFavourable).ToList(),
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        AccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                    });
                }
            }

            return combinations;
        }
    }
}
