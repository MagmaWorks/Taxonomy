using System;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public class InvalidSteelSpecificationException : Exception
    {
        public InvalidSteelSpecificationException(string t) : base(t) { }
    }
}
