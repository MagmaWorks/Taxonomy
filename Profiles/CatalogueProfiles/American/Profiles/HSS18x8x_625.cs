namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS18x8x_625 : SingletonAmericanBase<HSS18x8x_625>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS18X8X.625";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(16.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(6.26, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS18x8x_625() { }
    }
}
