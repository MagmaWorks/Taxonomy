namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS12x3x_188 : SingletonAmericanBase<HSS12x3x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS12X3X.188";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(11.50, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS12x3x_188() { }
    }
}
