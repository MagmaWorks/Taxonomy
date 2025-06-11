using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public class VariableCase : IVariableCase
    {
        public string Nickname { get; set; }
        public bool IsFavourable { get; set; } = false;
        public bool IsHorizontal { get; set; } = false;
        public ActionClass ActionClass => ActionClass.Variable;
        public string Name { get; set; }
        public Ratio CombinationFactor { get; set; }
        public Ratio FrequentFactor { get; set; }
        public Ratio QuasiPermanentFactor { get; set; }
        public IList<ILoad> Loads { get; set; } = new List<ILoad>();

        public VariableCase() { }
    }
}
