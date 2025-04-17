namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J102x102x23 : SingletonEuropeanBase<J102x102x23>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.J;
        public override string Label => "J 102 × 102 × 23";
        public Length Height => new Length(101.6, LengthUnit.Millimeter);
        public Length Width => new Length(101.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(11.1, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(5.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(81, LengthUnit.Millimeter);

        public J102x102x23() { }
    }
}
