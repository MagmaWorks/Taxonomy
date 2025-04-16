namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class U40x20x5 : SingletonEuropeanBase<U40x20x5>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.U;
        public override string Label => "U 40 × 20 × 5";
        public Length Height => new Length(40, LengthUnit.Millimeter);
        public Length Width => new Length(20, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(5.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(2.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(19, LengthUnit.Millimeter);

        public U40x20x5() { }
    }
}
