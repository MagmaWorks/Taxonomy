namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J76x76x15 : SingletonEuropeanBase<J76x76x15>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.J;
        public override string Label => "J 76 × 76 × 15";
        public Length Height => new Length(76.2, LengthUnit.Millimeter);
        public Length Width => new Length(80, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9.4, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4.7, LengthUnit.Millimeter);
        public Length WebHeight => new Length(59.4, LengthUnit.Millimeter);

        public J76x76x15() { }
    }
}
