using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class VariableCase : IVariableCase
    {
        public string Name { get; set; }
        public Ratio Characteristic { get; set; }
        public Ratio Frequent { get; set; }
        public Ratio QuasiPermanent { get; set; }
        public IList<ILoad> Loads { get; set; }

        public VariableCase() { }
    }
}
