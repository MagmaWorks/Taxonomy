namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000x554 : SingletonEuropeanBase<HL1000x554>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1000 × 554";
        public Length Height => new Length(1032, LengthUnit.Millimeter);
        public Length Width => new Length(408, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(52, LengthUnit.Millimeter);
        public Length WebThickness => new Length(29.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000x554() { }
    }
}
