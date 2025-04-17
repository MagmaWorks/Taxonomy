namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP200x53 : SingletonEuropeanBase<HP200x53>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 200 × 53";
        public Length Height => new Length(204, LengthUnit.Millimeter);
        public Length Width => new Length(207, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public HP200x53() { }
    }
}
