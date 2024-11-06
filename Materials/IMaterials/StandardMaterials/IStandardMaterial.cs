using System;
using MagmaWorks.Taxonomy.Standards;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IStandardMaterial<Std, Grd> : IMaterial
        where Grd : Enum where Std : IStandard
    {
        Std Standard { get; }
        Grd Grade { get; }
    }
}
