namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN140 : SingletonEuropeanBase<UPN140>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 140";
        public Length Height => new Length(140, LengthUnit.Millimeter);
        public Length Width => new Length(60, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(98, LengthUnit.Millimeter);

        public UPN140() { }
    }
}
