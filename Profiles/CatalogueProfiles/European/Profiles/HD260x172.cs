namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD260x172 : SingletonEuropeanBase<HD260x172>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 260 × 172";
        public Length Height => new Length(290, LengthUnit.Millimeter);
        public Length Width => new Length(268, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(32.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HD260x172() { }
    }
}
