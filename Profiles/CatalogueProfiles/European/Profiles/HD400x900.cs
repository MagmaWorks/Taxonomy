namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x900 : SingletonEuropeanBase<HD400x900>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 900";
        public Length Height => new Length(531, LengthUnit.Millimeter);
        public Length Width => new Length(442, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(106, LengthUnit.Millimeter);
        public Length WebThickness => new Length(65.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x900() { }
    }
}
