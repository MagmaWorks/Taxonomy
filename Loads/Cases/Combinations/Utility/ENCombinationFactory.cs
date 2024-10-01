using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits.Units;
using OasysUnits;
using System.Xml.Linq;

namespace MagmaWorks.Taxonomy.Loads
{
    public static partial class ENCombinationFactory
    {
        public static IList<IEquilibriumCombination> CreateEquSetA(IList<ILoadCase> cases)
        {
            return CreateEquSetA(cases, NationalAnnex.RecommendedValues);
        }

        public static IList<IEquilibriumCombination> CreateEquSetA(IList<ILoadCase> cases, NationalAnnex nationalAnnex)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            int caseId = 1;
            TableA1Properties factors = EN1990_TableA1_1[nationalAnnex];
            var combinations = new List<IEquilibriumCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new EquilibriumCombination()
                {
                    Name = $"LC{caseId++}: EQU Set A, Eq. 6.10 - Leading {variables[i].Name}",
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
                        Name = $"LC{caseId++}: EQU Set A, Eq. 6.10 - Leading {variables[i].Name} with unfavourable permanent",
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

        public static IList<IMemberDesignCombination> CreateStrGeoSetB(IList<ILoadCase> cases)
        {
            return CreateStrGeoSetB(cases, NationalAnnex.RecommendedValues, true);
        }

        public static IList<IMemberDesignCombination> CreateStrGeoSetB(IList<ILoadCase> cases, NationalAnnex nationalAnnex, bool use6_10aAnd6_10b)
        {
            if (use6_10aAnd6_10b)
            {
                return CreateSTR6_10aAnd6_10b(cases, nationalAnnex);
            }
            else
            {
                return CreateSTR6_10(cases, nationalAnnex);
            }
        }

        public static IList<IGeotechnicalMemberDesignCombination> CreateStrGeoSetC(IList<ILoadCase> cases)
        {
            return CreateStrGeoSetC(cases, NationalAnnex.RecommendedValues);
        }

        public static IList<IGeotechnicalMemberDesignCombination> CreateStrGeoSetC(IList<ILoadCase> cases, NationalAnnex nationalAnnex)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            int caseId = 1;
            TableA1Properties factors = EN1990_TableA1_1[nationalAnnex];
            var combinations = new List<IGeotechnicalMemberDesignCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new GeotechnicalMemberDesignCombination()
                {
                    Name = $"LC{caseId++}: STR/GEO Set C, Eq. 6.10 - Leading {variables[i].Name}",
                    PermanentCases = permanents,
                    PermanentPartialFactor = factors.Gamma_Gsup,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    LeadingVariablePartialFactor = factors.Gamma_Q1,
                    AccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    AccompanyingPartialFactor = factors.Gamma_Qi,
                });

                if (variables[i].IsHorizontal)
                {
                    combinations.Add(new GeotechnicalMemberDesignCombination()
                    {
                        Name = $"LC{caseId++}: STR/GEO Set C, Eq. 6.10 - Leading {variables[i].Name} with unfavourable permanent",
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

        public static IList<IAccidentialCombination> CreateAccidential(IVariableCase accidentalCase, Ratio partialFactor,
            IList<ILoadCase> otherCases, NationalAnnex nationalAnnex, bool useFrequentCombinationFactorForMainAccompanying)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(otherCases);
            int caseId = 1;
            TableA1Properties factors = EN1990_TableA1_1[nationalAnnex];
            var combinations = new List<IAccidentialCombination>();
            if (!useFrequentCombinationFactorForMainAccompanying)
            {
                combinations.Add(new AccidentialCombination()
                {
                    Name = $"Accidential, Eq. 6.11a/b - Leading {accidentalCase.Name}",
                    PermanentCases = permanents,
                    OtherAccompanyingVariableCases = variables,
                    UseFrequentCombinationFactorForMainAccompanying = false
                });
                return combinations;
            }

            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new AccidentialCombination()
                {
                    Name = $"LC{caseId++}: Accidential, Eq. 6.11a/b - Leading {accidentalCase.Name} combined with {variables[i].Name} as main accompanying variable action",
                    PermanentCases = permanents,
                    LeadingAccidentialPartialFactor = partialFactor,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    OtherAccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    UseFrequentCombinationFactorForMainAccompanying = true
                });
            }

            return combinations;
        }

        public static ISeismicCombination CreateSeismic(IVariableCase seismicCase, Ratio partialFactor, IList<ILoadCase> otherCases, NationalAnnex nationalAnnex)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(otherCases);
            return new SeismicCombination()
            {
                Name = $"Seismic, Eq. 6.12a/b - Leading {seismicCase.Name}",
                PermanentCases = permanents,
                LeadingVariableCases = new List<IVariableCase>() { seismicCase },
                LeadingSeismicPartialFactor = partialFactor,
                AccompanyingVariableCases = variables,
            };
        }

        private static IList<IMemberDesignCombination> CreateSTR6_10(IList<ILoadCase> cases, NationalAnnex nationalAnnex)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            int caseId = 1;
            TableA1Properties factors = EN1990_TableA1_2[nationalAnnex];
            var combinations = new List<IMemberDesignCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new MemberDesignCombination()
                {
                    Name = $"LC{caseId++}: STR/GEO Set B, Eq. 6.10 - Leading {variables[i].Name}",
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
                        Name = $"LC{caseId++}: STR/GEO Set B, Eq. 6.10 - Leading {variables[i].Name} with unfavourable permanent",
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

        private static IList<IMemberDesignCombination> CreateSTR6_10aAnd6_10b(IList<ILoadCase> cases, NationalAnnex nationalAnnex)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            int caseId = 1;
            TableA1Properties factors = EN1990_TableA1_2[nationalAnnex];
            var combinations = new List<IMemberDesignCombination>();

            bool onlyOne6_10a = Equals(factors.Gamma_Q1, factors.Gamma_Qi);
            if (onlyOne6_10a)
            {
                combinations.Add(new MemberDesignCombination()
                {
                    Name = $"LC{caseId++}: STR/GEO Set B, Eq. 6.10a - Leading Permanent combined with accompanying variable actions",
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
                        Name = $"LC{caseId++}: STR/GEO Set B, Eq. 6.10a - Leading Permanent combined with {variables[i].Name} as main accompanying variable action",
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
                    Name = $"LC{caseId++}: STR/GEO Set B, Eq. 6.10b - Leading {variables[i].Name}",
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
                        Name = $"LC{caseId++}: STR/GEO Set B, Eq. 6.10b - Leading {variables[i].Name} with unfavourable permanent",
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

        private static (IList<IPermanentCase> Permanents, IList<IVariableCase> Variables) SortLoadCases(IList<ILoadCase> cases)
        {
            var permanent = new List<IPermanentCase>();
            var variable = new List<IVariableCase>();
            foreach (var item in cases)
            {
                switch (item)
                {
                    case IPermanentCase permanentCase:
                        permanent.Add(permanentCase);
                        continue;

                    case IVariableCase variableCase:
                        variable.Add(variableCase);
                        continue;

                    default:
                        throw new System.Exception($"Unrecognised type of load case: {item.GetType()}");
                }
            }

            return (permanent, variable);
        }

        private static readonly Dictionary<NationalAnnex, TableA1Properties> EN1990_TableA1_1 = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1Properties(1.1, 0.9, 1.5, 1.5) },
            { NationalAnnex.UnitedKingdom, new TableA1Properties(1.1, 0.9, 1.5, 1.5) },

        };

        private static readonly Dictionary<NationalAnnex, TableA1Properties> EN1990_TableA1_2 = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1Properties(1.35, 1.0, 1.5, 1.5, 0.85) },
            { NationalAnnex.UnitedKingdom, new TableA1Properties(1.35, 1.0, 1.5, 1.5, 0.925) },

        };

        private static readonly Dictionary<NationalAnnex, TableA1Properties> EN1990_TableA1_3 = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1Properties(1.0, 1.0, 1.3, 1.3) },
            { NationalAnnex.UnitedKingdom, new TableA1Properties(1.0, 1.0, 1.3, 1.3) },
        };

        private struct TableA1Properties
        {
            internal Ratio Gamma_Gsup;
            internal Ratio Gamma_Ginf;
            internal Ratio Gamma_Q1;
            internal Ratio Gamma_Qi;
            internal Ratio Xi;

            internal TableA1Properties(double gamma_Gsup, double gamma_Ginf, double gamma_Q1, double gamma_Qi, double xi)
            {
                RatioUnit unit = RatioUnit.DecimalFraction;
                Gamma_Gsup = new Ratio(gamma_Gsup, unit);
                Gamma_Ginf = new Ratio(gamma_Ginf, unit);
                Gamma_Q1 = new Ratio(gamma_Q1, unit);
                Gamma_Qi = new Ratio(gamma_Qi, unit);
                Xi = new Ratio(xi, unit);
            }

            internal TableA1Properties(double gamma_Gsup, double gamma_Ginf, double gamma_Q1, double gamma_Qi)
            {
                RatioUnit unit = RatioUnit.DecimalFraction;
                Gamma_Gsup = new Ratio(gamma_Gsup, unit);
                Gamma_Ginf = new Ratio(gamma_Ginf, unit);
                Gamma_Q1 = new Ratio(gamma_Q1, unit);
                Gamma_Qi = new Ratio(gamma_Qi, unit);
                Xi = Ratio.Zero;
            }
        }
    }
}
