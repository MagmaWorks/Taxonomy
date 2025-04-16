namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE650x343 : SingletonEuropeanBase<HE650x343>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HE;
        public override string Label => "HE 650 × 343";
        public Length Height => new Length(680, LengthUnit.Millimeter);
        public Length Width => new Length(309, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(46, LengthUnit.Millimeter);
        public Length WebThickness => new Length(25, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE650x343() { }
    }
}
