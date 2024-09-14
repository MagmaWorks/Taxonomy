using System;
using MagmaWorks.Taxonomy.Standards;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IStandardMaterial : IMaterial
    {
        IStandard Standard { get; }
        Enum Grade { get; }
    }
}
