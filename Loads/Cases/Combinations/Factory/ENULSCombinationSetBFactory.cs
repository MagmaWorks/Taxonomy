using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Loads.Combinations.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public static partial class ENCombinationFactory
    {
        public static IList<IMemberDesignCombination> CreateStrGeoSetB(IList<ILoadCase> cases, string prefix = "LC", int firstCaseId = 1)
        {
            return CreateStrGeoSetB(cases, NationalAnnex.RecommendedValues, true, prefix, firstCaseId);
        }

        public static IList<IMemberDesignCombination> CreateStrGeoSetB(IList<ILoadCase> cases, NationalAnnex nationalAnnex, bool use6_10aAnd6_10b, string prefix = "LC", int firstCaseId = 1)
        {
            if (use6_10aAnd6_10b)
            {
                return CreateSTR6_10aAnd6_10b(cases, nationalAnnex, prefix, firstCaseId);
            }
            else
            {
                return CreateSTR6_10(cases, nationalAnnex, prefix, firstCaseId);
            }
        }

        private static IList<IMemberDesignCombination> CreateSTR6_10(IList<ILoadCase> cases, NationalAnnex nationalAnnex, string prefix = "LC", int firstCaseId = 1)
        {
            TableA1_2Properties factors = new ENTableA1_2B().GetProperties(nationalAnnex);
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            var combinations = new List<IMemberDesignCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                var combination = new MemberDesignCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: STR/GEO Set B, Eq. 6.10 - Leading {variables[i].Name}",
                    PermanentPartialFactor = factors.Gamma_Gsup,
                    PermanentReductionFactor = new Ratio(1.0, RatioUnit.DecimalFraction),
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    LeadingVariablePartialFactor = factors.Gamma_Q1,
                    OtherAccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    AccompanyingPartialFactor = factors.Gamma_Qi,
                };

                combination.SetPermanentCases(permanents);
                combinations.Add(combination);

                if (variables[i].IsHorizontal)
                {
                    combination = new MemberDesignCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: STR/GEO Set B, Eq. 6.10 - Leading {variables[i].Name} with unfavourable permanent",
                        PermanentPartialFactor = factors.Gamma_Ginf,
                        PermanentReductionFactor = new Ratio(1.0, RatioUnit.DecimalFraction),
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        LeadingVariablePartialFactor = factors.Gamma_Q1,
                        OtherAccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                        AccompanyingPartialFactor = factors.Gamma_Qi,
                    };

                    combination.SetPermanentCases(permanents);
                    combinations.Add(combination);
                }
            }

            return combinations;
        }

        private static IList<IMemberDesignCombination> CreateSTR6_10aAnd6_10b(IList<ILoadCase> cases, NationalAnnex nationalAnnex, string prefix = "LC", int firstCaseId = 1)
        {
            TableA1_2Properties factors = new ENTableA1_2B().GetProperties(nationalAnnex);
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            var combinations = new List<IMemberDesignCombination>();
            bool onlyOne6_10a = Equals(factors.Gamma_Q1, factors.Gamma_Qi);

            MemberDesignCombination combination = null;
            if (onlyOne6_10a)
            {
                combination = new MemberDesignCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: STR/GEO Set B, Eq. 6.10a - Leading Permanent combined with accompanying variable actions",
                    PermanentPartialFactor = factors.Gamma_Gsup,
                    PermanentReductionFactor = new Ratio(1.0, RatioUnit.DecimalFraction),
                    OtherAccompanyingVariableCases = variables,
                    AccompanyingPartialFactor = factors.Gamma_Qi,
                };

                combination.SetPermanentCases(permanents);
                combinations.Add(combination);
            }

            for (int i = 0; i < variables.Count; i++)
            {
                if (!onlyOne6_10a)
                {
                    combination = new MemberDesignCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: STR/GEO Set B, Eq. 6.10a - Leading Permanent combined with {variables[i].Name} as main accompanying variable action",
                        PermanentPartialFactor = factors.Gamma_Gsup,
                        PermanentReductionFactor = new Ratio(1.0, RatioUnit.DecimalFraction),
                        MainAccompanyingVariableCases = new List<IVariableCase>() { variables[i] },
                        LeadingVariablePartialFactor = factors.Gamma_Q1,
                        OtherAccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                        AccompanyingPartialFactor = factors.Gamma_Qi,
                    };

                    combination.SetPermanentCases(permanents);
                    combinations.Add(combination);
                }

                combination = new MemberDesignCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: STR/GEO Set B, Eq. 6.10b - Leading {variables[i].Name}",
                    PermanentPartialFactor = factors.Gamma_Gsup,
                    PermanentReductionFactor = factors.Xi,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    LeadingVariablePartialFactor = factors.Gamma_Q1,
                    OtherAccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    AccompanyingPartialFactor = factors.Gamma_Qi,
                };

                combination.SetPermanentCases(permanents);
                combinations.Add(combination);

                if (variables[i].IsHorizontal)
                {
                    combination = new MemberDesignCombination()
                    {
                        Name = $"{prefix}{firstCaseId++}: STR/GEO Set B, Eq. 6.10b - Leading {variables[i].Name} with unfavourable permanent",
                        PermanentPartialFactor = factors.Gamma_Ginf,
                        PermanentReductionFactor = factors.Xi,
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        LeadingVariablePartialFactor = factors.Gamma_Q1,
                        OtherAccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                        AccompanyingPartialFactor = factors.Gamma_Qi,
                    };

                    combination.SetPermanentCases(permanents);
                    combinations.Add(combination);
                }
            }

            return combinations;
        }
    }
}
