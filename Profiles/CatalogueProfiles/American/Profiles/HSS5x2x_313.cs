namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS5x2x_313 : SingletonAmericanBase<HSS5x2x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS5X2X.313";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(4.13, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.13, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS5x2x_313() { }
    }
}
