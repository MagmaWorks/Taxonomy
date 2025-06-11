using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public class PermanentCase : IPermanentCase
    {
        public string Nickname { get; set; } = "G";
        public bool IsHorizontal { get; set; } = false;
        public string Name { get; set; } = "Dead Load";
        public IList<ILoad> Loads { get; set; } = new List<ILoad>();

        public PermanentCase() { }
    }
}
