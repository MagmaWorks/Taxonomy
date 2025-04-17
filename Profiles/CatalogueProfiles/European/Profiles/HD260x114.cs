namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD260x114 : SingletonEuropeanBase<HD260x114>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 260 × 114";
        public Length Height => new Length(268, LengthUnit.Millimeter);
        public Length Width => new Length(262, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HD260x114() { }
    }
}
