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
                var combination = new CharacteristicCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: SLS Characteristic - Leading {variables[i].Name}",
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    AccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                };

                combination.SetPermanentCases(permanents);
                combinations.Add(combination);

                if (variables[i].IsHorizontal)
                {
                    combination = new CharacteristicCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: SLS Characteristic - Leading {variables[i].Name} with unfavourable permanent",
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        AccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                    };

                    combination.SetPermanentCases(permanents);
                    combinations.Add(combination);
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
                var combination = new FrequentCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: SLS Frequent - Leading {variables[i].Name}",
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    AccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                };

                combination.SetPermanentCases(permanents);
                combinations.Add(combination);

                if (variables[i].IsHorizontal)
                {
                    combination = new FrequentCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: SLS Frequent - Leading {variables[i].Name} with unfavourable permanent",
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        AccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                    };

                    combination.SetPermanentCases(permanents);
                    combinations.Add(combination);
                }
            }

            return combinations;
        }

        public static IList<IQuasiPermanentCombination> CreateQuasiPermanent(IList<ILoadCase> cases, string prefix = "LC", int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            var combinations = new List<IQuasiPermanentCombination>();

            var combination = new QuasiPermanentCombination()
            {
                Name = $"{prefix}{firstCaseId++}: SLS Quasi-permanent",
                AccompanyingVariableCases = variables.Where(lc => lc.QuasiPermanentFactor.Value != 0).ToList(),
            };

            combination.SetPermanentCases(permanents);
            combinations.Add(combination);

            return combinations;
        }
    }
}
