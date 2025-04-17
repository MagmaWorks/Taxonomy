namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x449 : SingletonEuropeanBase<HL920x449>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 449";
        public Length Height => new Length(948, LengthUnit.Millimeter);
        public Length Width => new Length(423, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(42.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x449() { }
    }
}
