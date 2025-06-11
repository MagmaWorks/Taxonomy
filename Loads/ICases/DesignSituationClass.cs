using System;

namespace MagmaWorks.Taxonomy.Loads
{
    [Flags]
    public enum DesignSituationClass
    {
        Persistent = 1,
        Transient = 2,
        PersistentAndTransient = Persistent | Transient, // = 3
        Accidental = 4,
        Seismic = 8
    }
}
