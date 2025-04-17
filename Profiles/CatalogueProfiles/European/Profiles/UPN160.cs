namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN160 : SingletonEuropeanBase<UPN160>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 160";
        public Length Height => new Length(160, LengthUnit.Millimeter);
        public Length Width => new Length(65, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(5.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(115, LengthUnit.Millimeter);

        public UPN160() { }
    }
}
