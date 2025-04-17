namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP400x213 : SingletonEuropeanBase<HP400x213>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 400 × 213";
        public Length Height => new Length(368, LengthUnit.Millimeter);
        public Length Width => new Length(400, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(24, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.2, LengthUnit.Millimeter);

        public HP400x213() { }
    }
}
