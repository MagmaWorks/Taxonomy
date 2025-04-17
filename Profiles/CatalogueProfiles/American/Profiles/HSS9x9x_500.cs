namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS9x9x_500 : SingletonAmericanBase<HSS9x9x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS9X9X.500";
        public Length Height => new Length(9.00, LengthUnit.Inch);
        public Length Width => new Length(9.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(7.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(7.60, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS9x9x_500() { }
    }
}
