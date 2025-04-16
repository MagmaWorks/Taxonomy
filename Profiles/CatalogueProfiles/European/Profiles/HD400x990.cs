namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x990 : SingletonEuropeanBase<HD400x990>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 990";
        public Length Height => new Length(550, LengthUnit.Millimeter);
        public Length Width => new Length(448, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(115, LengthUnit.Millimeter);
        public Length WebThickness => new Length(71.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x990() { }
    }
}
