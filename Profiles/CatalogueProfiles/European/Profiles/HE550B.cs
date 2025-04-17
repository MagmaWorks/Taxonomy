namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE550B : SingletonEuropeanBase<HE550B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 550 B";
        public Length Height => new Length(550, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(29, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE550B() { }
    }
}
