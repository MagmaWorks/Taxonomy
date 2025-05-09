namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x421 : SingletonEuropeanBase<HD400x421>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 421";
        public Length Height => new Length(425, LengthUnit.Millimeter);
        public Length Width => new Length(409, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(52.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(32.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x421() { }
    }
}
