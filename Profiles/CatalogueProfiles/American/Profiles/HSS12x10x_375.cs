namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS12x10x_375 : SingletonAmericanBase<HSS12x10x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS12X10X.375";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(11.00, LengthUnit.Inch);
        public Length FlatWidth => new Length(8.95, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS12x10x_375() { }
    }
}
