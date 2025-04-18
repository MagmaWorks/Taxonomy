namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB305x127x37 : SingletonEuropeanBase<UB305x127x37>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 305 × 127 × 37";
        public Length Height => new Length(304.4, LengthUnit.Millimeter);
        public Length Width => new Length(123.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8.9, LengthUnit.Millimeter);

        public UB305x127x37() { }
    }
}
