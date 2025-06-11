using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    internal static class Utility
    {
        public static IList<ILoad> FactorLoads<T>(Ratio partialFactor, IList<T> loadCases)
    where T : ILoadCase
        {
            var factoredLoads = new List<ILoad>();
            if (loadCases == null || loadCases.Count == 0)
            {
                return factoredLoads;
            }

            foreach (T loadCase in loadCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    factoredLoads.Add(load.Factor(partialFactor));
                }
            }

            return factoredLoads;
        }

        public static IList<ILoad> FactorLoads<T>(IDesignSituation designSitation, IList<T> loadCases, IList<bool> isFavourable)
            where T : ILoadCase
        {
            var factoredLoads = new List<ILoad>();
            if (loadCases == null || loadCases.Count == 0)
            {
                return factoredLoads;
            }

            for (int i = 0; i < loadCases.Count; i++)
            {
                T loadCase = loadCases[i];
                foreach (ILoad load in loadCase.Loads)
                {
                    if (isFavourable[i])
                    {
                        factoredLoads.Add(load.Factor(new Ratio(designSitation.FavourablePermanentActionsPartialFactor * designSitation.ReductionFactor, RatioUnit.DecimalFraction)));
                    }
                    else
                    {
                        factoredLoads.Add(load.Factor(new Ratio(designSitation.UnfavourablePermanentActionsPartialFactor * designSitation.ReductionFactor, RatioUnit.DecimalFraction)));
                    }
                }
            }

            return factoredLoads;
        }

        public static IList<ILoad> GetLoads<T>(IList<T> loadCases)
            where T : ILoadCase
        {
            var factoredLoads = new List<ILoad>();
            if (loadCases == null || loadCases.Count == 0)
            {
                return factoredLoads;
            }

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
            if (loadCases == null || loadCases.Count == 0)
            {
                return factoredLoads;
            }

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
            if (loadCases == null || loadCases.Count == 0)
            {
                return factoredLoads;
            }

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

        internal static string DescriptionHelper<T>(IList<T> cases, IList<bool> isFavourable, IDesignSituation designSituation) where T : ILoadCase
        {
            if (cases == null || cases.Count == 0)
            {
                return string.Empty;
            }

            var favourables = new List<ILoadCase>();
            var unfavourables = new List<ILoadCase>();
            for (int i = 0; i < cases.Count; i++)
            {
                ILoadCase lc = cases[i];
                if (isFavourable[i])
                {
                    favourables.Add(lc);
                }
                else
                {
                    unfavourables.Add(lc);
                }
            }

            StringBuilder desc = new StringBuilder();
            var reductionFactor = new Ratio(designSituation.ReductionFactor, RatioUnit.DecimalFraction);
            if (unfavourables.Count > 0)
            {
                var factor = new Ratio(designSituation.UnfavourablePermanentActionsPartialFactor, RatioUnit.DecimalFraction);

                if (designSituation.ReductionFactor != 1.0)
                {
                    desc.Append(DescriptionHelper(unfavourables, factor, reductionFactor));
                }
                else
                {
                    desc.Append(DescriptionHelper(unfavourables, factor));
                }
            }

            if (favourables.Count > 0)
            {
                var factor = new Ratio(designSituation.FavourablePermanentActionsPartialFactor, RatioUnit.DecimalFraction);
                if (designSituation.ReductionFactor != 1.0)
                {
                    desc.Append(DescriptionHelper(favourables, factor, reductionFactor));
                }
                else
                {
                    desc.Append(DescriptionHelper(favourables, factor));
                }
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
