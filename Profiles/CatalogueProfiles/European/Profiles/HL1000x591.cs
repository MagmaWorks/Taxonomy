namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000x591 : SingletonEuropeanBase<HL1000x591>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1000 × 591";
        public Length Height => new Length(1040, LengthUnit.Millimeter);
        public Length Width => new Length(409, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(55.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(31, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000x591() { }
    }
}
