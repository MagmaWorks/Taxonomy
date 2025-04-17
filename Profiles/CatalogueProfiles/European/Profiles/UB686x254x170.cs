namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB686x254x170 : SingletonEuropeanBase<UB686x254x170>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 686 × 254 × 170";
        public Length Height => new Length(692.9, LengthUnit.Millimeter);
        public Length Width => new Length(255.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(23.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UB686x254x170() { }
    }
}
