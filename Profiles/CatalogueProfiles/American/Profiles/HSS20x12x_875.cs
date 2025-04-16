namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS20x12x_875 : SingletonAmericanBase<HSS20x12x_875>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS20X12X.875";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(17.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(9.56, LengthUnit.Inch);
        public Length Thickness => new Length(0.88, LengthUnit.Inch);

        public HSS20x12x_875() { }
    }
}
