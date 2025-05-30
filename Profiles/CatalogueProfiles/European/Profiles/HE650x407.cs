namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE650x407 : SingletonEuropeanBase<HE650x407>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HE;
        public override string Label => "HE 650 × 407";
        public Length Height => new Length(696, LengthUnit.Millimeter);
        public Length Width => new Length(314, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(54, LengthUnit.Millimeter);
        public Length WebThickness => new Length(29.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE650x407() { }
    }
}
