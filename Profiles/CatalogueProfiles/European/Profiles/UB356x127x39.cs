namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB356x127x39 : SingletonEuropeanBase<UB356x127x39>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 356 × 127 × 39";
        public Length Height => new Length(353.4, LengthUnit.Millimeter);
        public Length Width => new Length(126, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB356x127x39() { }
    }
}
