namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS9x7x_250 : SingletonAmericanBase<HSS9x7x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS9X7X.250";
        public Length Height => new Length(9.00, LengthUnit.Inch);
        public Length Width => new Length(7.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(8.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(6.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS9x7x_250() { }
    }
}
