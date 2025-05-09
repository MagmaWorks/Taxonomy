namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000M : SingletonEuropeanBase<HL1000M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1000 M";
        public Length Height => new Length(1008, LengthUnit.Millimeter);
        public Length Width => new Length(402, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(40, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000M() { }
    }
}
