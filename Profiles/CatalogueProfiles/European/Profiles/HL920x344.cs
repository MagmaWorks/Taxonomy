namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x344 : SingletonEuropeanBase<HL920x344>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 344";
        public Length Height => new Length(927, LengthUnit.Millimeter);
        public Length Width => new Length(418, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(32, LengthUnit.Millimeter);
        public Length WebThickness => new Length(19.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x344() { }
    }
}
