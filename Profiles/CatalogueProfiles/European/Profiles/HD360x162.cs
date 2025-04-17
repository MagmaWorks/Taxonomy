namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD360x162 : SingletonEuropeanBase<HD360x162>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 360 × 162";
        public Length Height => new Length(364, LengthUnit.Millimeter);
        public Length Width => new Length(371, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD360x162() { }
    }
}
