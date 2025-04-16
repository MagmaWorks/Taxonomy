namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB610x305x238 : SingletonEuropeanBase<UB610x305x238>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 610 × 305 × 238";
        public Length Height => new Length(635.8, LengthUnit.Millimeter);
        public Length Width => new Length(311.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(31.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public UB610x305x238() { }
    }
}
