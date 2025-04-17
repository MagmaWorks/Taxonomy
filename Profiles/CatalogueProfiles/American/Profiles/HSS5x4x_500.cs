namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS5x4x_500 : SingletonAmericanBase<HSS5x4x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS5X4X.500";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(3.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.60, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS5x4x_500() { }
    }
}
