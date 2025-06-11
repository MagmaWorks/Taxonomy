using System;
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
                var combination = new EquilibriumCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: EQU Set A, Eq. 6.10 - Leading {variables[i].Name}",
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
                };

                combination.SetPermanentCases(permanents, permanents.Select(x => true).ToList());
                combinations.Add(combination);

                if (variables[i].IsHorizontal)
                {
                    combination = new EquilibriumCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: EQU Set A, Eq. 6.10 - Leading {variables[i].Name} with favourable permanent",
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
                    };

                    combination.SetPermanentCases(permanents, permanents.Select(x => true).ToList());
                    combinations.Add(combination);
                }
            }

            // favourable permanent
            var favourable = new EquilibriumCombination()
            {
                Name = $"{prefix}{firstCaseId++}: EQU Set A, Eq. 6.10 - Leading {variables[1].Name} with favourable permanent",
                LeadingVariableCases = new List<IVariableCase>() { variables[1] },
                AccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != 1).ToList(),
                DesignSitation = new DesignSituation()
                {
                    Class = DesignSituationClass.Persistent,
                    UnfavourablePermanentActionsPartialFactor = factors.Gamma_Gsup.Value,
                    FavourablePermanentActionsPartialFactor = factors.Gamma_Ginf.Value,
                    LeadingActionPartialFactor = factors.Gamma_Q1.Value,
                    OtherAccompanyingVariableActionsPartialFactor = factors.Gamma_Qi.Value
                }
            };

            favourable.SetPermanentCases(permanents, permanents.Select(x => true).ToList());
            combinations.Add(favourable);

            return combinations;
        }
    }
}
