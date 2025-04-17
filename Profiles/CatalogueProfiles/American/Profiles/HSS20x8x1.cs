namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS20x8x1 : SingletonAmericanBase<HSS20x8x1>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS20X8X1";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(17.20, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.21, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS20x8x1() { }
    }
}
