namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS20x6x_250 : SingletonAmericanBase<HSS20x6x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS20X6X.250";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(19.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS20x6x_250() { }
    }
}
