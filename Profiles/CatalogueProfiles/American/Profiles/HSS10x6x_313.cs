namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS10x6x_313 : SingletonAmericanBase<HSS10x6x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS10X6X.313";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(9.13, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.13, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS10x6x_313() { }
    }
}
