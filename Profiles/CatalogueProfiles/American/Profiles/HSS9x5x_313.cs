namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS9x5x_313 : SingletonAmericanBase<HSS9x5x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS9X5X.313";
        public Length Height => new Length(9.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(8.13, LengthUnit.Inch);
        public Length FlatWidth => new Length(4.13, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS9x5x_313() { }
    }
}
