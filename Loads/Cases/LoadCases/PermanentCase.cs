using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class PermanentCase : IPermanentCase
    {
        public string Name { get; set; }
        public IList<ILoad> Loads { get; set; }

        public PermanentCase() { }
    }
}
