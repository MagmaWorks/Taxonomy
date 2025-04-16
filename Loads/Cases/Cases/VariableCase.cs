using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public class VariableCase : IVariableCase
    {
        public string Nickname { get; set; }
        public bool IsFavourable { get; set; } = false;
        public bool IsHorizontal { get; set; } = false;
        public string Name { get; set; }
        public Ratio Characteristic { get; set; }
        public Ratio Frequent { get; set; }
        public Ratio QuasiPermanent { get; set; }
        public IList<ILoad> Loads { get; set; } = new List<ILoad>();

        public VariableCase() { }
    }
}
