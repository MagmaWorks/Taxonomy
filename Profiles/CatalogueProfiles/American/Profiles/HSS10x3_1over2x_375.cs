namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS10x3_1over2x_375 : SingletonAmericanBase<HSS10x3_1over2x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS10X3-1/2X.375";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(8.95, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.45, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS10x3_1over2x_375() { }
    }
}
