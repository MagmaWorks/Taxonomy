namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000x883 : SingletonEuropeanBase<HL1000x883>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1000 × 883";
        public Length Height => new Length(1092, LengthUnit.Millimeter);
        public Length Width => new Length(424, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(82, LengthUnit.Millimeter);
        public Length WebThickness => new Length(45.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000x883() { }
    }
}
