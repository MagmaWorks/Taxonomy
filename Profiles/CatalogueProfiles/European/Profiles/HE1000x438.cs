namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE1000x438 : SingletonEuropeanBase<HE1000x438>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HE;
        public override string Label => "HE 1000 × 438";
        public Length Height => new Length(1026, LengthUnit.Millimeter);
        public Length Width => new Length(305, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(49, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE1000x438() { }
    }
}
