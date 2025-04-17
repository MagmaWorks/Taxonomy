namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000x539 : SingletonEuropeanBase<HL1000x539>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1000 × 539";
        public Length Height => new Length(1030, LengthUnit.Millimeter);
        public Length Width => new Length(407, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(51.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(28.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000x539() { }
    }
}
