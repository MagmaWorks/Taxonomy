namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN240 : SingletonEuropeanBase<UPN240>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 240";
        public Length Height => new Length(240, LengthUnit.Millimeter);
        public Length Width => new Length(85, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(184, LengthUnit.Millimeter);

        public UPN240() { }
    }
}
