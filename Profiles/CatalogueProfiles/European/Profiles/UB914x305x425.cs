namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x425 : SingletonEuropeanBase<UB914x305x425>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 914 × 305 × 425";
        public Length Height => new Length(961, LengthUnit.Millimeter);
        public Length Width => new Length(313, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(49, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x425() { }
    }
}
