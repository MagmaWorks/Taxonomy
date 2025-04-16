namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x634 : SingletonEuropeanBase<HD400x634>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 634";
        public Length Height => new Length(474, LengthUnit.Millimeter);
        public Length Width => new Length(424, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(77.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(47.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x634() { }
    }
}
