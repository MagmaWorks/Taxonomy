namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x347 : SingletonEuropeanBase<HD400x347>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 347";
        public Length Height => new Length(407, LengthUnit.Millimeter);
        public Length Width => new Length(404, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(43.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(27.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x347() { }
    }
}
