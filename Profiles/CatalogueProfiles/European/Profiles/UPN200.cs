namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN200 : SingletonEuropeanBase<UPN200>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 200";
        public Length Height => new Length(200, LengthUnit.Millimeter);
        public Length Width => new Length(75, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(11.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6, LengthUnit.Millimeter);
        public Length WebHeight => new Length(151, LengthUnit.Millimeter);

        public UPN200() { }
    }
}
