namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS12x3x_250 : SingletonAmericanBase<HSS12x3x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS12X3X.250";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(11.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS12x3x_250() { }
    }
}
