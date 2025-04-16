namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN400 : SingletonEuropeanBase<IPN400>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 400";
        public Length Height => new Length(400, LengthUnit.Millimeter);
        public Length Width => new Length(155, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(14.4, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8.6, LengthUnit.Millimeter);
        public Length WebHeight => new Length(323, LengthUnit.Millimeter);

        public IPN400() { }
    }
}
