using System;
using MagmaWorks.Taxonomy.Standards;

namespace MagmaWorks.Taxonomy.Materials
{
    public class StandardMaterial : IStandardMaterial
    {
        public IStandard Standard { get; set; }
        public Enum Grade { get; set; }
        public MaterialType Type { get; set; }

        public StandardMaterial(MaterialType type, IStandard standard, Enum grade)
        {
            Type = type;
            Standard = standard;
            Grade = grade;
        }
    }
}
