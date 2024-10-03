using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public static partial class ENCombinationFactory
    {
        public static IList<IMemberDesignCombination> CreateStrGeoSetB(IList<ILoadCase> cases, int firstCaseId = 1)
        {
            return CreateStrGeoSetB(cases, NationalAnnex.RecommendedValues, true, firstCaseId);
        }

        public static IList<IMemberDesignCombination> CreateStrGeoSetB(IList<ILoadCase> cases, NationalAnnex nationalAnnex, bool use6_10aAnd6_10b, int firstCaseId = 1)
        {
            if (use6_10aAnd6_10b)
            {
                return CreateSTR6_10aAnd6_10b(cases, nationalAnnex, firstCaseId);
            }
            else
            {
                return CreateSTR6_10(cases, nationalAnnex, firstCaseId);
            }
        }

        private static IList<IMemberDesignCombination> CreateSTR6_10(IList<ILoadCase> cases, NationalAnnex nationalAnnex, int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            if (!EN1990_TableA1_2B.TryGetValue(nationalAnnex, out TableA1Properties factors))
            {
                throw new System.NotImplementedException($"NA {nationalAnnex} not implemented for EN1990 Table A1.2(B) values");
            };

            var combinations = new List<IMemberDesignCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new MemberDesignCombination()
                {
                    Name = $"LC{firstCaseId++}: STR/GEO Set B, Eq. 6.10 - Leading {variables[i].Name}",
                    PermanentCases = permanents,
                    PermanentPartialFactor = factors.Gamma_Gsup,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    LeadingVariablePartialFactor = factors.Gamma_Q1,
                    OtherAccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    AccompanyingPartialFactor = factors.Gamma_Qi,
                });

                if (variables[i].IsHorizontal)
                {
                    combinations.Add(new MemberDesignCombination()
                    {
                        Name = $"LC{firstCaseId++}: STR/GEO Set B, Eq. 6.10 - Leading {variables[i].Name} with unfavourable permanent",
                        PermanentCases = permanents.Where((item, index) => !item.IsFavourable).ToList(),
                        PermanentPartialFactor = factors.Gamma_Ginf,
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        LeadingVariablePartialFactor = factors.Gamma_Q1,
                        OtherAccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                        AccompanyingPartialFactor = factors.Gamma_Qi,
                    });
                }
            }

            return combinations;
        }

        private static IList<IMemberDesignCombination> CreateSTR6_10aAnd6_10b(IList<ILoadCase> cases, NationalAnnex nationalAnnex, int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            if (!EN1990_TableA1_2B.TryGetValue(nationalAnnex, out TableA1Properties factors))
            {
                throw new System.NotImplementedException($"NA {nationalAnnex} not implemented for EN1990 Table A1.2(B) values");
            };

            var combinations = new List<IMemberDesignCombination>();
            bool onlyOne6_10a = Equals(factors.Gamma_Q1, factors.Gamma_Qi);
            if (onlyOne6_10a)
            {
                combinations.Add(new MemberDesignCombination()
                {
                    Name = $"LC{firstCaseId++}: STR/GEO Set B, Eq. 6.10a - Leading Permanent combined with accompanying variable actions",
                    PermanentCases = permanents,
                    PermanentPartialFactor = factors.Gamma_Gsup,
                    OtherAccompanyingVariableCases = variables,
                    AccompanyingPartialFactor = factors.Gamma_Qi,
                });
            }

            for (int i = 0; i < variables.Count; i++)
            {
                if (!onlyOne6_10a)
                {
                    combinations.Add(new MemberDesignCombination()
                    {
                        Name = $"LC{firstCaseId++}: STR/GEO Set B, Eq. 6.10a - Leading Permanent combined with {variables[i].Name} as main accompanying variable action",
                        PermanentCases = permanents,
                        PermanentPartialFactor = factors.Gamma_Gsup,
                        MainAccompanyingVariableCases = new List<IVariableCase>() { variables[i] },
                        LeadingVariablePartialFactor = factors.Gamma_Q1,
                        OtherAccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                        AccompanyingPartialFactor = factors.Gamma_Qi,
                    });
                }

                combinations.Add(new MemberDesignCombination()
                {
                    Name = $"LC{firstCaseId++}: STR/GEO Set B, Eq. 6.10b - Leading {variables[i].Name}",
                    PermanentCases = permanents,
                    PermanentPartialFactor = factors.Gamma_Gsup,
                    PermanentReductionFactor = factors.Xi,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    LeadingVariablePartialFactor = factors.Gamma_Q1,
                    OtherAccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    AccompanyingPartialFactor = factors.Gamma_Qi,
                });

                if (variables[i].IsHorizontal)
                {
                    combinations.Add(new MemberDesignCombination()
                    {
                        Name = $"LC{firstCaseId++}: STR/GEO Set B, Eq. 6.10b - Leading {variables[i].Name} with unfavourable permanent",
                        PermanentCases = permanents.Where((item, index) => !item.IsFavourable).ToList(),
                        PermanentPartialFactor = factors.Gamma_Ginf,
                        PermanentReductionFactor = factors.Xi,
                        LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                        LeadingVariablePartialFactor = factors.Gamma_Q1,
                        OtherAccompanyingVariableCases = variables.Where((item, index) => item.IsHorizontal && index != i).ToList(),
                        AccompanyingPartialFactor = factors.Gamma_Qi,
                    });
                }
            }

            return combinations;
        }

        private static readonly Dictionary<NationalAnnex, TableA1Properties> EN1990_TableA1_2B = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1Properties(1.35, 1.0, 1.5, 1.5, 0.85) },
            { NationalAnnex.UnitedKingdom, new TableA1Properties(1.35, 1.0, 1.5, 1.5, 0.925) },

        };
    }
}
