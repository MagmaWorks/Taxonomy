using System.Collections.Generic;
using System.Linq;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles.Utility
{
    internal static class Description
    {
        internal static string Create(params Length[] values)
        {
            return Create("×", values);
        }

        internal static string Create(string separator, params Length[] values)
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
            return $"{string.Join(separator, strings)} {Length.GetAbbreviation(u)}";
        }

        internal static string FormatDoubleWithSignificantDigits(double value, int significantDigitsAfterRadix)
        {
            string s = value.ToString($"N{significantDigitsAfterRadix}");
            while (s[s.Length - 1] == '0')
            {
                s = s.Remove(s.Length - 1);
            }

            return s;
        }
    }
}
