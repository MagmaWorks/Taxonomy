namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB356x127x33 : SingletonEuropeanBase<UB356x127x33>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 356 × 127 × 33";
        public Length Height => new Length(349, LengthUnit.Millimeter);
        public Length Width => new Length(125.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB356x127x33() { }
    }
}
