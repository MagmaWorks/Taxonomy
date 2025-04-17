namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH305x89x42 : SingletonEuropeanBase<CH305x89x42>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.CH;
        public override string Label => "CH 305 × 89 × 42";
        public Length Height => new Length(304.8, LengthUnit.Millimeter);
        public Length Width => new Length(88.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(25.7, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(12.8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(227, LengthUnit.Millimeter);

        public CH305x89x42() { }
    }
}
