using MagmaWorks.Taxonomy.Standards;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials
{
    public interface IStandardMaterial : IMaterial
    {
        IStandard Standard { get; }
    }
}
