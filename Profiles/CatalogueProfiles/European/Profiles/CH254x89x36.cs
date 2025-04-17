namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH254x89x36 : SingletonEuropeanBase<CH254x89x36>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.CH;
        public override string Label => "CH 254 × 89 × 36";
        public Length Height => new Length(254, LengthUnit.Millimeter);
        public Length Width => new Length(88.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(20.4, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(10.2, LengthUnit.Millimeter);
        public Length WebHeight => new Length(183, LengthUnit.Millimeter);

        public CH254x89x36() { }
    }
}
