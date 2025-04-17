namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB533x210x92 : SingletonEuropeanBase<UB533x210x92>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 533 × 210 × 92";
        public Length Height => new Length(533.1, LengthUnit.Millimeter);
        public Length Width => new Length(209.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UB533x210x92() { }
    }
}
