using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public static partial class ENCombinationFactory
    {
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
