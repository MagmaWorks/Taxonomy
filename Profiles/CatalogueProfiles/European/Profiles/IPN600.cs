namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN600 : SingletonEuropeanBase<IPN600>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 600";
        public Length Height => new Length(600, LengthUnit.Millimeter);
        public Length Width => new Length(215, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(32.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21.6, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(13, LengthUnit.Millimeter);
        public Length WebHeight => new Length(485, LengthUnit.Millimeter);

        public IPN600() { }
    }
}
