namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL920x787 : SingletonEuropeanBase<HL920x787>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HL;
        public override string Label => "HL 920 × 787";
        public Length Height => new Length(1011, LengthUnit.Millimeter);
        public Length Width => new Length(437, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(73.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(40.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public HL920x787() { }
    }
}
