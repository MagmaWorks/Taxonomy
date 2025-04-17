namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS18x6x_750 : SingletonAmericanBase<HSS18x6x_750>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS18X6X.750";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(15.90, LengthUnit.Inch);
        public Length FlatWidth => new Length(3.91, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS18x6x_750() { }
    }
}
