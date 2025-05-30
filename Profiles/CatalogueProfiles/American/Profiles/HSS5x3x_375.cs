namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS5x3x_375 : SingletonAmericanBase<HSS5x3x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS5X3X.375";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(3.95, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.95, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS5x3x_375() { }
    }
}
