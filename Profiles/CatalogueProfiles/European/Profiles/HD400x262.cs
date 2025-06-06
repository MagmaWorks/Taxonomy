namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x262 : SingletonEuropeanBase<HD400x262>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 262";
        public Length Height => new Length(387, LengthUnit.Millimeter);
        public Length Width => new Length(398, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(33.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x262() { }
    }
}
