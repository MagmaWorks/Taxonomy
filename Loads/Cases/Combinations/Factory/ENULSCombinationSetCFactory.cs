using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Loads.Combinations.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public static partial class ENCombinationFactory
    {

        private static readonly Dictionary<NationalAnnex, TableA1_2Properties> EN1990_TableA1_2C = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1_2Properties(1.0, 1.0, 1.3, 1.3) },
            { NationalAnnex.UnitedKingdom, new TableA1_2Properties(1.0, 1.0, 1.3, 1.3) },
        };

        public static IList<IGeotechnicalMemberDesignCombination> CreateStrGeoSetC(IList<ILoadCase> cases, string prefix = "LC", int firstCaseId = 1)
        {
            return CreateStrGeoSetC(cases, NationalAnnex.RecommendedValues, prefix, firstCaseId);
        }

        public static IList<IGeotechnicalMemberDesignCombination> CreateStrGeoSetC(IList<ILoadCase> cases, NationalAnnex nationalAnnex, string prefix = "LC", int firstCaseId = 1)
        {
            TableA1_2Properties factors = new ENTableA1_2C().GetProperties(nationalAnnex);
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            var combinations = new List<IGeotechnicalMemberDesignCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                var combination = new GeotechnicalMemberDesignCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: STR/GEO Set C, Eq. 6.10 - Leading {variables[i].Name}",
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    AccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    DesignSituation = new DesignSituation()
                    {
                        Class = DesignSituationClass.Transient,
                        UnfavourablePermanentActionsPartialFactor = factors.Gamma_Gsup.Value,
                        FavourablePermanentActionsPartialFactor = factors.Gamma_Ginf.Value,
                        LeadingActionPartialFactor = factors.Gamma_Q1.Value,
                        OtherAccompanyingVariableActionsPartialFactor = factors.Gamma_Qi.Value
                    }
                };

                combination.SetPermanentCases(permanents);
                combinations.Add(combination);

                if (variables[i].IsHorizontal)
                {
                    combination = new GeotechnicalMemberDesignCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: STR/GEO Set C, Eq. 6.10 - Leading {variables[i].Name} with favourable permanent",
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        AccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                        DesignSituation = new DesignSituation()
                        {
                            Class = DesignSituationClass.Transient,
                            UnfavourablePermanentActionsPartialFactor = factors.Gamma_Gsup.Value,
                            FavourablePermanentActionsPartialFactor = factors.Gamma_Ginf.Value,
                            LeadingActionPartialFactor = factors.Gamma_Q1.Value,
                            OtherAccompanyingVariableActionsPartialFactor = factors.Gamma_Qi.Value
                        }
                    };

                    combination.SetPermanentCases(permanents, permanents.Select(x => false).ToList());
                    combinations.Add(combination);
                }
            }

            return combinations;
        }
    }
}
