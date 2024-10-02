using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads
{
    public static partial class ENCombinationFactory
    {
        public static IList<IGeotechnicalMemberDesignCombination> CreateStrGeoSetC(IList<ILoadCase> cases, int firstCaseId = 1)
        {
            return CreateStrGeoSetC(cases, NationalAnnex.RecommendedValues, firstCaseId);
        }

        public static IList<IGeotechnicalMemberDesignCombination> CreateStrGeoSetC(IList<ILoadCase> cases, NationalAnnex nationalAnnex, int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(cases);
            if (!EN1990_TableA1_2C.TryGetValue(nationalAnnex, out TableA1Properties factors))
            {
                throw new System.NotImplementedException($"NA {nationalAnnex} not implemented for EN1990 Table A1.2(C) values");
            };

            var combinations = new List<IGeotechnicalMemberDesignCombination>();
            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new GeotechnicalMemberDesignCombination()
                {
                    Name = $"LC{firstCaseId++}: STR/GEO Set C, Eq. 6.10 - Leading {variables[i].Name}",
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
                        Name = $"LC{firstCaseId++}: STR/GEO Set C, Eq. 6.10 - Leading {variables[i].Name} with unfavourable permanent",
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

        private static readonly Dictionary<NationalAnnex, TableA1Properties> EN1990_TableA1_2C = new()
        {
            { NationalAnnex.RecommendedValues, new TableA1Properties(1.0, 1.0, 1.3, 1.3) },
            { NationalAnnex.UnitedKingdom, new TableA1Properties(1.0, 1.0, 1.3, 1.3) },
        };
    }
}
