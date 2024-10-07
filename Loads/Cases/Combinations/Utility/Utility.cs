using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MagmaWorks.Taxonomy.Loads.Cases;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    internal static class Utility
    {
        public static IList<ILoad> FactorLoads<T>(Ratio partialFactor, IList<T> loadCases)
            where T : ILoadCase
        {
            var factoredLoads = new List<ILoad>();
            foreach (T loadCase in loadCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    factoredLoads.Add(load.Factor(partialFactor));
                }
            }

            return factoredLoads;
        }

        public static IList<ILoad> FactorAccompanyingVariableLoads<T>(Ratio partialFactor, IList<T> loadCases, Func<T, Ratio> selector)
            where T : IVariableCase
        {
            var factoredLoads = new List<ILoad>();
            foreach (T loadCase in loadCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    Ratio factor = partialFactor * selector(loadCase).DecimalFractions;
                    factoredLoads.Add(load.Factor(factor));
                }
            }

            return factoredLoads;
        }

        public static IList<ILoad> SelectAccompanyingVariableLoads<T>(IList<T> loadCases, Func<T, Ratio> selector)
            where T : IVariableCase
        {
            var factoredLoads = new List<ILoad>();
            foreach (T loadCase in loadCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    factoredLoads.Add(load.Factor(selector(loadCase)));
                }
            }

            return factoredLoads;
        }

        internal static string DescriptionHelper<T>(IList<T> cases, Ratio factor) where T : ILoadCase
        {
            if (cases == null || cases.Count == 0 || factor.Value == 0)
            {
                return string.Empty;
            }

            if (cases.Count == 1)
            {
                if (factor.DecimalFractions == 1)
                {
                    return GetNickname(cases.First());
                }
                else
                {
                    return $"{factor}·{GetNickname(cases.First())}";
                }
            }

            StringBuilder desc = new StringBuilder();
            if (factor.Value != 1)
            {
                desc.AppendLine($"{factor}·(");
            }

            foreach (ILoadCase lc in cases)
            {
                desc.Append($"{GetNickname(lc)} + ");
            }

            desc.Remove(desc.Length - 3, 3);
            if (factor.Value != 1)
            {
                desc.AppendLine(")");
            }

            return desc.ToString();
        }

        internal static string DescriptionHelper<T>(IList<T> cases, Ratio factor1, Ratio factor2) where T : ILoadCase
        {
            if (cases == null || cases.Count == 0 || factor1.Value == 0)
            {
                return string.Empty;
            }
            string f2 = factor2.DecimalFractions == 1 ? string.Empty : $"{factor2}·";

            if (cases.Count == 1)
            {
                return $"{factor1}·{f2}{GetNickname(cases.First())}";
            }

            StringBuilder desc = new StringBuilder();
            desc.AppendLine($"{factor1}·{f2}(");
            foreach (ILoadCase lc in cases)
            {
                desc.Append($"{GetNickname(lc)} + ");
            }

            desc.Remove(desc.Length - 3, 3);
            desc.AppendLine(")");
            return desc.ToString();
        }

        internal static string DescriptionHelper<T>(IList<T> cases, Ratio factor, Func<T, Ratio> selector)
            where T : IVariableCase
        {
            if (cases == null || cases.Count == 0 || factor.Value == 0)
            {
                return string.Empty;
            }

            if (cases.Count == 1)
            {
                Ratio phi = selector(cases.First());
                if (factor.DecimalFractions == 1)
                {
                    return $"{phi}·{GetNickname(cases.First())}";
                }
                else
                {
                    return $"{factor}·{phi}·{GetNickname(cases.First())}";
                }
            }

            StringBuilder desc = new StringBuilder();
            if (factor.Value != 1)
            {
                desc.AppendLine($"{factor}·(");
            }

            foreach (ILoadCase lc in cases)
            {
                Ratio phi = selector((T)lc);
                if (phi.Value != 0)
                {
                    desc.Append($"{phi}·{GetNickname(lc)} + ");
                }
            }

            if (desc.Length > 3)
            {
                desc.Remove(desc.Length - 3, 3);
            }

            if (factor.Value != 1)
            {
                desc.AppendLine(")");
            }

            return desc.ToString();
        }

        internal static string JoinDescriptions(string[] strings)
        {
            string joined = string.Join(" + ", strings).Replace(" +  + ", " + ");
            if (!joined.EndsWith(" + "))
            {
                return joined;
            }

            return joined.Remove(joined.LastIndexOf(" + "));
        }

        private static string GetNickname(ILoadCase loadCase)
        {
            if (loadCase.Nickname.Contains(' '))
            {
                return $"'{loadCase.Nickname}'";
            }

            return loadCase.Nickname;
        }
    }
}
