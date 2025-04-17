namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1000AA : SingletonEuropeanBase<HL1000AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 1000 AA";
        public Length Height => new Length(982, LengthUnit.Millimeter);
        public Length Width => new Length(400, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(27.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1000AA() { }
    }
}
