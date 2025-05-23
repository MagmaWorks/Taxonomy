namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class U65x42x5_5 : SingletonEuropeanBase<U65x42x5_5>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.U;
        public override string Label => "U 65 × 42 × 5,5";
        public Length Height => new Length(65, LengthUnit.Millimeter);
        public Length Width => new Length(42, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4, LengthUnit.Millimeter);
        public Length WebHeight => new Length(34, LengthUnit.Millimeter);

        public U65x42x5_5() { }
    }
}
