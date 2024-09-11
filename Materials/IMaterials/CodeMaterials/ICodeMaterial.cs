using System;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface ICodeMaterial : IMaterial
    {
        //Code Code { get; }
        Enum Grade { get; }
    }
}
