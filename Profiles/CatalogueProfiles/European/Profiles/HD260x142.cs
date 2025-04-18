namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD260x142 : SingletonEuropeanBase<HD260x142>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 260 × 142";
        public Length Height => new Length(278, LengthUnit.Millimeter);
        public Length Width => new Length(265, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(26.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HD260x142() { }
    }
}
