namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x237 : SingletonEuropeanBase<HD400x237>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 237";
        public Length Height => new Length(380, LengthUnit.Millimeter);
        public Length Width => new Length(395, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(30.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x237() { }
    }
}
