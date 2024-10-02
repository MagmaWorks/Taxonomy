using System.Collections.Generic;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads
{
    public static partial class ENCombinationFactory
    {
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


    }
}
