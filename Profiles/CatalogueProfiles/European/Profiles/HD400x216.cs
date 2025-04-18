namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x216 : SingletonEuropeanBase<HD400x216>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 216";
        public Length Height => new Length(375, LengthUnit.Millimeter);
        public Length Width => new Length(394, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(27.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x216() { }
    }
}
