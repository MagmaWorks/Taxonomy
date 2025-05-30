namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN65 : SingletonEuropeanBase<UPN65>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 65";
        public Length Height => new Length(65, LengthUnit.Millimeter);
        public Length Width => new Length(42, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4, LengthUnit.Millimeter);
        public Length WebHeight => new Length(34, LengthUnit.Millimeter);

        public UPN65() { }
    }
}
