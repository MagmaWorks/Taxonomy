namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x187 : SingletonEuropeanBase<HD400x187>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 187";
        public Length Height => new Length(368, LengthUnit.Millimeter);
        public Length Width => new Length(391, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(24, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x187() { }
    }
}
