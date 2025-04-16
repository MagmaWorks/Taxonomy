namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x8x_250 : SingletonAmericanBase<HSS24x8x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X8X.250";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(23.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(7.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS24x8x_250() { }
    }
}
