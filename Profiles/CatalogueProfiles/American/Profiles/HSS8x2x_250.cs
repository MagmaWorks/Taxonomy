namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS8x2x_250 : SingletonAmericanBase<HSS8x2x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS8X2X.250";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(7.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS8x2x_250() { }
    }
}
