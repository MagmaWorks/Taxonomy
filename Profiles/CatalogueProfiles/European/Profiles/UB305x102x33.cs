namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB305x102x33 : SingletonEuropeanBase<UB305x102x33>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 305 × 102 × 33";
        public Length Height => new Length(312.7, LengthUnit.Millimeter);
        public Length Width => new Length(102.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB305x102x33() { }
    }
}
