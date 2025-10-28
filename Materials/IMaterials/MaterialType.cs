namespace MagmaWorks.Taxonomy.Materials
{
    public enum MaterialType
    {
        Generic = 0,
        Concrete = 1,
        Steel = 2,
        Timber = 3,
        Masonry = 4,
        Aluminium = 5,
        Reinforcement = 6,
        FRP = 7,
        Glass = 8,
        Fabric = 9,
        [Obsolete("This value is deprecated. Use Timber instead.")]
        SolidTimber = 10,
        [Obsolete("This value is deprecated. Use Timber instead.")]
        GluedLaminatedTimber = 11,
        RammedEarth = 12
    }
}
