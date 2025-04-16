namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x551 : SingletonEuropeanBase<HD400x551>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 551";
        public Length Height => new Length(455, LengthUnit.Millimeter);
        public Length Width => new Length(418, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(67.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(42, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x551() { }
    }
}
