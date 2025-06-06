namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB1016x305x314 : SingletonEuropeanBase<UB1016x305x314>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 1016 × 305 × 314";
        public Length Height => new Length(1000, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(35.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(19.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public UB1016x305x314() { }
    }
}
