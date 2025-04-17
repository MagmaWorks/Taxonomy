namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x1194 : SingletonEuropeanBase<HL920x1194>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 1194";
        public Length Height => new Length(1081, LengthUnit.Millimeter);
        public Length Width => new Length(457, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(109, LengthUnit.Millimeter);
        public Length WebThickness => new Length(60.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x1194() { }
    }
}
