namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS4x2x_313 : SingletonAmericanBase<HSS4x2x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS4X2X.313";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(3.13, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.13, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS4x2x_313() { }
    }
}
