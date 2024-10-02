using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads
{
    public static partial class ENCombinationFactory
    {
        public static IList<IAccidentialCombination> CreateAccidential(IVariableCase accidentalCase, Ratio partialFactor,
            IList<ILoadCase> otherCases, NationalAnnex nationalAnnex, bool useFrequentCombinationFactorForMainAccompanying, int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(otherCases);
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
                    Name = $"LC{firstCaseId++}: Accidential, Eq. 6.11a/b - Leading {accidentalCase.Name} combined with {variables[i].Name} as main accompanying variable action",
                    PermanentCases = permanents,
                    LeadingAccidentialPartialFactor = partialFactor,
                    LeadingVariableCases = new List<IVariableCase>() { variables[i] },
                    OtherAccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    UseFrequentCombinationFactorForMainAccompanying = true
                });
            }

            return combinations;
        }

        public static IList<ISeismicCombination> CreateSeismic(IList<IVariableCase> seismicCases, Ratio partialFactor,
            IList<ILoadCase> otherCases, NationalAnnex nationalAnnex, int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(otherCases);
            var combinations = new List<ISeismicCombination>();
            for (int i = 0; i < seismicCases.Count; i++)
            {
                combinations.Add(new SeismicCombination()
                {
                    Name = $"LC{firstCaseId++}: Seismic, Eq. 6.12a/b - Leading {seismicCases[i].Name}",
                    PermanentCases = permanents,
                    LeadingVariableCases = new List<IVariableCase>() { seismicCases[i] },
                    LeadingSeismicPartialFactor = partialFactor,
                    AccompanyingVariableCases = variables,
                } );
            }

            return combinations;
        }
    }
}
