namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB178x102x19 : SingletonEuropeanBase<UB178x102x19>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 178 × 102 × 19";
        public Length Height => new Length(177.8, LengthUnit.Millimeter);
        public Length Width => new Length(101.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB178x102x19() { }
    }
}
