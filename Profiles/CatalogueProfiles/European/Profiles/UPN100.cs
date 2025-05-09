namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN100 : SingletonEuropeanBase<UPN100>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 100";
        public Length Height => new Length(100, LengthUnit.Millimeter);
        public Length Width => new Length(50, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(64, LengthUnit.Millimeter);

        public UPN100() { }
    }
}
