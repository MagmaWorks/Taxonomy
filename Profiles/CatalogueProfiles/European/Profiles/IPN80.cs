namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN80 : SingletonEuropeanBase<IPN80>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 80";
        public Length Height => new Length(80, LengthUnit.Millimeter);
        public Length Width => new Length(42, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(3.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(3.9, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(2.3, LengthUnit.Millimeter);
        public Length WebHeight => new Length(59, LengthUnit.Millimeter);

        public IPN80() { }
    }
}
