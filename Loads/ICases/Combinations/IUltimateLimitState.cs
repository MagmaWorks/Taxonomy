﻿namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface IUltimateLimitState : ILoadCombination
    {
        IDesignSituation DesignSituation { get; }
    }
}
