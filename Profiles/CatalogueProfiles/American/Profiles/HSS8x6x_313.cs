namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS8x6x_313 : SingletonAmericanBase<HSS8x6x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS8X6X.313";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(7.13, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.13, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS8x6x_313() { }
    }
}
