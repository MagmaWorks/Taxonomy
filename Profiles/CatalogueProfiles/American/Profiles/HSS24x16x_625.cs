namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x16x_625 : SingletonAmericanBase<HSS24x16x_625>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X16X.625";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(22.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(14.3, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS24x16x_625() { }
    }
}
