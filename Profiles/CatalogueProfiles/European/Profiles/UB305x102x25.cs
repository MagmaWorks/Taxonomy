namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB305x102x25 : SingletonEuropeanBase<UB305x102x25>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 305 × 102 × 25";
        public Length Height => new Length(305.1, LengthUnit.Millimeter);
        public Length Width => new Length(101.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB305x102x25() { }
    }
}
