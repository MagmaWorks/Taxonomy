using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public static partial class ENCombinationFactory
    {
        public static IList<IAccidentalCombination> CreateAccidental(IVariableCase accidentalCase, double partialFactor,
            IList<ILoadCase> otherCases, NationalAnnex nationalAnnex, bool useFrequentCombinationFactorForMainAccompanying,
            string prefix = "LC", int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(otherCases);
            var combinations = new List<IAccidentalCombination>();
            if (!useFrequentCombinationFactorForMainAccompanying)
            {
                combinations.Add(new AccidentalCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: Accidental, Eq. 6.11a/b - Leading {accidentalCase.Name}",
                    PermanentCases = permanents,
                    LeadingVariableCases = new List<IVariableCase>() { accidentalCase },
                    OtherAccompanyingVariableCases = variables,
                    UseFrequentCombinationFactorForMainAccompanying = false,
                    DesignSitation = new DesignSituation()
                    {
                        Class = DesignSituationClass.Seismic,
                        LeadingActionPartialFactor = partialFactor
                    }
                });
                return combinations;
            }

            for (int i = 0; i < variables.Count; i++)
            {
                combinations.Add(new AccidentalCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: Accidental, Eq. 6.11a/b - Leading {accidentalCase.Name} combined with {variables[i].Name} as main accompanying variable action",
                    PermanentCases = permanents,
                    LeadingVariableCases = new List<IVariableCase>() { accidentalCase },
                    MainAccompanyingVariableCases = new List<IVariableCase>() { variables[i] },
                    OtherAccompanyingVariableCases = variables.Where((item, index) => index != i).ToList(),
                    UseFrequentCombinationFactorForMainAccompanying = true,
                    DesignSitation = new DesignSituation()
                    {
                        Class = DesignSituationClass.Seismic,
                        LeadingActionPartialFactor = partialFactor
                    }
                });
            }

            return combinations;
        }

        public static IList<ISeismicCombination> CreateSeismic(IList<IVariableCase> seismicCases, Ratio partialFactor,
            IList<ILoadCase> otherCases, NationalAnnex nationalAnnex, string prefix = "LC", int firstCaseId = 1)
        {
            (IList<IPermanentCase> permanents, IList<IVariableCase> variables) = SortLoadCases(otherCases);
            var combinations = new List<ISeismicCombination>();
            for (int i = 0; i < seismicCases.Count; i++)
            {
                combinations.Add(new SeismicCombination()
                {
                    Name = $"{prefix}{firstCaseId++}: Seismic, Eq. 6.12a/b - Leading {seismicCases[i].Name}",
                    PermanentCases = permanents,
                    LeadingVariableCases = new List<IVariableCase>() { seismicCases[i] },
                    LeadingSeismicPartialFactor = partialFactor,
                    AccompanyingVariableCases = variables,
                });
            }

            return combinations;
        }
    }
}
