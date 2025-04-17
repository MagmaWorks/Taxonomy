namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB254x146x31 : SingletonEuropeanBase<UB254x146x31>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 254 × 146 × 31";
        public Length Height => new Length(251.4, LengthUnit.Millimeter);
        public Length Width => new Length(146.1, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB254x146x31() { }
    }
}
