namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x381 : SingletonEuropeanBase<UB914x305x381>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 914 × 305 × 381";
        public Length Height => new Length(951, LengthUnit.Millimeter);
        public Length Width => new Length(310, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(43.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x381() { }
    }
}
