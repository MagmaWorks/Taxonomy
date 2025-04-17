namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS9x7x_625 : SingletonAmericanBase<HSS9x7x_625>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS9X7X.625";
        public Length Height => new Length(9.00, LengthUnit.Inch);
        public Length Width => new Length(7.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(7.26, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.26, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS9x7x_625() { }
    }
}
