namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN120 : SingletonEuropeanBase<UPN120>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 120";
        public Length Height => new Length(120, LengthUnit.Millimeter);
        public Length Width => new Length(55, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(82, LengthUnit.Millimeter);

        public UPN120() { }
    }
}
