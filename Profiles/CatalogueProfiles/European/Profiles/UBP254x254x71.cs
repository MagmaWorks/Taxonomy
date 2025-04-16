namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP254x254x71 : SingletonEuropeanBase<UBP254x254x71>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UBP;
        public override string Label => "UBP 254 × 254 × 71";
        public Length Height => new Length(249.7, LengthUnit.Millimeter);
        public Length Width => new Length(258, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UBP254x254x71() { }
    }
}
