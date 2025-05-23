namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x345 : SingletonEuropeanBase<UB914x305x345>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 914 × 305 × 345";
        public Length Height => new Length(943, LengthUnit.Millimeter);
        public Length Width => new Length(308, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(39.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(22.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x345() { }
    }
}
