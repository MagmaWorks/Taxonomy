namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x420 : SingletonEuropeanBase<HL920x420>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 420";
        public Length Height => new Length(943, LengthUnit.Millimeter);
        public Length Width => new Length(422, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(39.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(22.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x420() { }
    }
}
