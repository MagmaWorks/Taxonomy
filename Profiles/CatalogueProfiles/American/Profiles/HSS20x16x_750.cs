namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS20x16x_750 : SingletonAmericanBase<HSS20x16x_750>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS20X16X.750";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(17.90, LengthUnit.Inch);
        public Length FlatWidth => new Length(13.9, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS20x16x_750() { }
    }
}
