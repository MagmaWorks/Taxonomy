namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH229x76x26 : SingletonEuropeanBase<CH229x76x26>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.CH;
        public override string Label => "CH 229 × 76 × 26";
        public Length Height => new Length(228.6, LengthUnit.Millimeter);
        public Length Width => new Length(76.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8.8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(169, LengthUnit.Millimeter);

        public CH229x76x26() { }
    }
}
