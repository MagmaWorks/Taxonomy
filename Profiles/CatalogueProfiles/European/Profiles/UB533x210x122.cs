namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB533x210x122 : SingletonEuropeanBase<UB533x210x122>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 533 × 210 × 122";
        public Length Height => new Length(544.5, LengthUnit.Millimeter);
        public Length Width => new Length(211.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UB533x210x122() { }
    }
}
