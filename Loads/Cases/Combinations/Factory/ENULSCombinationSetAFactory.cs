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
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    AccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    DesignSitation = new DesignSituation()
                    {
                        Class = DesignSituationClass.Persistent,
                        UnfavourablePermanentActionsPartialFactor = factors.Gamma_Gsup.Value,
                        FavourablePermanentActionsPartialFactor = factors.Gamma_Ginf.Value,
                        LeadingActionPartialFactor = factors.Gamma_Q1.Value,
                        OtherAccompanyingVariableActionsPartialFactor = factors.Gamma_Qi.Value
                    }
                });

                if (variables[i].IsHorizontal)
                {
                    combinations.Add(new EquilibriumCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: EQU Set A, Eq. 6.10 - Leading {variables[i].Name} with favourable permanent",
                        PermanentCases = permanents.Where((item, index) => !item.IsFavourable).ToList(),
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        AccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                        DesignSitation = new DesignSituation()
                        {
                            Class = DesignSituationClass.Persistent,
                            UnfavourablePermanentActionsPartialFactor = factors.Gamma_Gsup.Value,
                            FavourablePermanentActionsPartialFactor = factors.Gamma_Ginf.Value,
                            LeadingActionPartialFactor = factors.Gamma_Q1.Value,
                            OtherAccompanyingVariableActionsPartialFactor = factors.Gamma_Qi.Value
                        }
                    });
                }
            }

            return combinations;
        }
    }
}
