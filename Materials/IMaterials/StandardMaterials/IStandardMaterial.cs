﻿using MagmaWorks.Taxonomy.Standards;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials
{
    public interface IStandardMaterial<TStandard> : IMaterial
        where TStandard : IStandard
    {
        TStandard Standard { get; }
    }
}
