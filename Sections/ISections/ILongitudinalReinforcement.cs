﻿namespace MagmaWorks.Taxonomy.Sections
{
    public interface ILongitudinalReinforcement : IComposite
    {
        IRebar Rebar { get; set; }
    }
}