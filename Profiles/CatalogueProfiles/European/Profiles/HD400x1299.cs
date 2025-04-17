namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x1299 : SingletonEuropeanBase<HD400x1299>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 1299";
        public Length Height => new Length(600, LengthUnit.Millimeter);
        public Length Width => new Length(476, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(140, LengthUnit.Millimeter);
        public Length WebThickness => new Length(100, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x1299() { }
    }
}
