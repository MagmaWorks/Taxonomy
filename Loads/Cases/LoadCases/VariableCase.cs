using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class VariableCase : IVariableCase
    {
        public string Nickname { get; set; } = "Q";
        public bool IsFavourable { get; set; } = false;
        public bool IsHorizontal { get; set; } = false;
        public string Name { get; set; } = "Live Load";
        public Ratio Characteristic { get; set; }
        public Ratio Frequent { get; set; }
        public Ratio QuasiPermanent { get; set; }
        public IList<ILoad> Loads { get; set; } = new List<ILoad>();

        public VariableCase() { }
    }
}
