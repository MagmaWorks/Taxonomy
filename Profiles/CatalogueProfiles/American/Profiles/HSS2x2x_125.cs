namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS2x2x_125 : SingletonAmericanBase<HSS2x2x_125>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS2X2X.125";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(1.65, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.65, LengthUnit.Inch);
        public Length Thickness => new Length(0.13, LengthUnit.Inch);

        public HSS2x2x_125() { }
    }
}
