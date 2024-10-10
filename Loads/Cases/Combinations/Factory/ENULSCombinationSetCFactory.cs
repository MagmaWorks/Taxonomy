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
                combinations.Add(new GeotechnicalMemberDesignCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: STR/GEO Set C, Eq. 6.10 - Leading {variables[i].Name}",
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
                        Name = $"{prefix}{firstCaseId++}: STR/GEO Set C, Eq. 6.10 - Leading {variables[i].Name} with unfavourable permanent",
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
