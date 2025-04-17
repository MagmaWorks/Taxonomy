namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J102x44x7 : SingletonEuropeanBase<J102x44x7>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.J;
        public override string Label => "J 102 × 44 × 7";
        public Length Height => new Length(101.6, LengthUnit.Millimeter);
        public Length Width => new Length(44.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(6.9, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(3.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(89.4, LengthUnit.Millimeter);

        public J102x44x7() { }
    }
}
