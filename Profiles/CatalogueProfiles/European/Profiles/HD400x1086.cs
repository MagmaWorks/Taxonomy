namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x1086 : SingletonEuropeanBase<HD400x1086>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 1086";
        public Length Height => new Length(569, LengthUnit.Millimeter);
        public Length Width => new Length(454, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(125, LengthUnit.Millimeter);
        public Length WebThickness => new Length(78, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x1086() { }
    }
}
