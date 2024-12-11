using System.Collections.Generic;
using System.Linq;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    internal static class Utility
    {
        internal static string Describe(params Length[] values)
        {
            return Describe("×", values);
        }

        internal static string Describe(string separator, params Length[] values)
        {
            var lengths = values.ToList();
            LengthUnit u = lengths.FirstOrDefault().Unit;
            int significantDigitsAfterRadix = 3;
            switch (u)
            {
                case LengthUnit.Millimeter:
                    significantDigitsAfterRadix = 0;
                    break;

                case LengthUnit.Centimeter:
                    significantDigitsAfterRadix = 1;
                    break;
            }

            List<string> strings = lengths.Select(s
                => FormatDoubleWithSignificantDigits(s.As(u), significantDigitsAfterRadix)).ToList();
            return $"{string.Join($"\u2009{separator}\u2009", strings)}\u2009{Length.GetAbbreviation(u)}";
        }

        internal static string FormatDoubleWithSignificantDigits(double value, int significantDigitsAfterRadix)
        {
            return value.ToString($"N{significantDigitsAfterRadix}");
        }
    }
}
