namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN320 : SingletonEuropeanBase<IPN320>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 320";
        public Length Height => new Length(320, LengthUnit.Millimeter);
        public Length Width => new Length(131, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(11.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6.9, LengthUnit.Millimeter);
        public Length WebHeight => new Length(258, LengthUnit.Millimeter);

        public IPN320() { }
    }
}
