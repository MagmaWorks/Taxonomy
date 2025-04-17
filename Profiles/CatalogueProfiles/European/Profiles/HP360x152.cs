namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP360x152 : SingletonEuropeanBase<HP360x152>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 360 × 152";
        public Length Height => new Length(356.4, LengthUnit.Millimeter);
        public Length Width => new Length(376, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP360x152() { }
    }
}
