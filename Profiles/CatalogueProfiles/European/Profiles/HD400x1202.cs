namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x1202 : SingletonEuropeanBase<HD400x1202>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 1202";
        public Length Height => new Length(580, LengthUnit.Millimeter);
        public Length Width => new Length(471, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(130, LengthUnit.Millimeter);
        public Length WebThickness => new Length(95, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x1202() { }
    }
}
