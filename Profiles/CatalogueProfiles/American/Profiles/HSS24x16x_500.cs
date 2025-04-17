namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x16x_500 : SingletonAmericanBase<HSS24x16x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X16X.500";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(22.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(14.6, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS24x16x_500() { }
    }
}
