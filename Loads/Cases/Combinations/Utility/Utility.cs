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

        public static IList<ILoad> GetLoads<T>(IList<T> loadCases)
            where T : ILoadCase
        {
            var factoredLoads = new List<ILoad>();
            foreach (T loadCase in loadCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    factoredLoads.Add(load);
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
                    if (factor.Value != 0)
                    {
                        factoredLoads.Add(load.Factor(factor));
                    }
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
                    Ratio phi = selector(loadCase);
                    if (phi.Value != 0)
                    {
                        factoredLoads.Add(load.Factor(phi));
                    }
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
                desc.Append($"{factor}·(");
            }

            foreach (ILoadCase lc in cases)
            {
                desc.Append($"{GetNickname(lc)} + ");
            }

            desc.Remove(desc.Length - 3, 3);
            if (factor.Value != 1)
            {
                desc.Append(")");
            }

            return desc.ToString();
        }

        internal static string DescriptionHelper<T>(IList<T> cases, Ratio factor1, Ratio factor2) where T : ILoadCase
        {
            if (cases == null || cases.Count == 0 || factor1.Value == 0)
            {
                return string.Empty;
            }

            if (cases.Count == 1)
            {
                return $"{MultiFactor(factor1, factor2)}·{GetNickname(cases.First())}";
            }

            StringBuilder desc = new StringBuilder();
            if (factor1.DecimalFractions != 1 || factor2.DecimalFractions != 1)
            {
                desc.Append($"{MultiFactor(factor1, factor2)}·(");
            }

            foreach (ILoadCase lc in cases)
            {
                desc.Append($"{GetNickname(lc)} + ");
            }

            desc.Remove(desc.Length - 3, 3);
            if (factor1.DecimalFractions != 1 || factor2.DecimalFractions != 1)
            {
                desc.Append(")");
            }

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
                return $"{MultiFactor(factor, phi)}·{GetNickname(cases.First())}";
            }

            StringBuilder desc = new StringBuilder();
            if (factor.Value != 1)
            {
                desc.Append($"{factor}·(");
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
                desc.Append(")");
            }

            return desc.ToString();
        }

        internal static string JoinDescriptions(string[] strings, string separator = " + ")
        {
            strings = strings.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return string.Join(separator, strings);
        }

        private static string GetNickname(ILoadCase loadCase)
        {
            if (loadCase.Nickname.Contains(' '))
            {
                return $"'{loadCase.Nickname}'";
            }

            return loadCase.Nickname;
        }

        private static string MultiFactor(Ratio factor1, Ratio factor2)
        {
            string f1 = factor1.DecimalFractions == 1 ? string.Empty : $"{factor1}";
            string f2 = factor2.DecimalFractions == 1 ? string.Empty : $"{factor2}";
            return JoinDescriptions(new string[] { f1, f2 }, "·");
        }
    }
}
