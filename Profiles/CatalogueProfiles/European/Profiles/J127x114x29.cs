namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J127x114x29 : SingletonEuropeanBase<J127x114x29>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.J;
        public override string Label => "J 127 × 114 × 29";
        public Length Height => new Length(127, LengthUnit.Millimeter);
        public Length Width => new Length(114.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9.9, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(104, LengthUnit.Millimeter);

        public J127x114x29() { }
    }
}
