namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC9x25_4 : SingletonAmericanBase<MC9x25_4>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC9X25.4";
        public Length Height => new Length(9.00, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.55, LengthUnit.Inch);
        public Length WebThickness => new Length(0.45, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.7, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.35, LengthUnit.Inch);
        public Length WebHeight => new Length(6.50, LengthUnit.Inch);

        public MC9x25_4() { }
    }
}
