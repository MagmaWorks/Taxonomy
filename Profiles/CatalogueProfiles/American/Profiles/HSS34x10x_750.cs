namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS34x10x_750 : SingletonAmericanBase<HSS34x10x_750>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS34X10X.750";
        public Length Height => new Length(34.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(31.90, LengthUnit.Inch);
        public Length FlatWidth => new Length(7.91, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS34x10x_750() { }
    }
}
