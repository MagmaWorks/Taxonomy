namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN180 : SingletonEuropeanBase<UPN180>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 180";
        public Length Height => new Length(180, LengthUnit.Millimeter);
        public Length Width => new Length(70, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(11, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(5.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(133, LengthUnit.Millimeter);

        public UPN180() { }
    }
}
