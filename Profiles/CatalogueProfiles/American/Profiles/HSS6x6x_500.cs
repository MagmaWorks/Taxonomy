namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6x6x_500 : SingletonAmericanBase<HSS6x6x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6X6X.500";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(4.61, LengthUnit.Inch);
        public Length FlatWidth => new Length(4.61, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS6x6x_500() { }
    }
}
