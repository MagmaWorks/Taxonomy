using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads
{
    public class PermanentCase : IPermanentCase
    {
        public bool IsFavourable { get; set; } = false;
        public bool IsHorizontal { get; set; } = false;
        public string Name { get; set; } = "Permanent Loads";
        public IList<ILoad> Loads { get; set; } = new List<ILoad>();

        public PermanentCase() { }
    }
}
