namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x1269 : SingletonEuropeanBase<HL920x1269>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 1269";
        public Length Height => new Length(1093, LengthUnit.Millimeter);
        public Length Width => new Length(461, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(115.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(64, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x1269() { }
    }
}
