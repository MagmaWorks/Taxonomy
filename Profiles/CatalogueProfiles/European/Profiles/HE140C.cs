namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE140C : SingletonEuropeanBase<HE140C>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEC;
        public override string Label => "HE 140 C";
        public Length Height => new Length(150, LengthUnit.Millimeter);
        public Length Width => new Length(143, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE140C() { }
    }
}
