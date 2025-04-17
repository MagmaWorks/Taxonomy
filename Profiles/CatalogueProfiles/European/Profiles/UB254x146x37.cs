namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB254x146x37 : SingletonEuropeanBase<UB254x146x37>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 254 × 146 × 37";
        public Length Height => new Length(256, LengthUnit.Millimeter);
        public Length Width => new Length(146.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB254x146x37() { }
    }
}
