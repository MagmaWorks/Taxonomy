namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS34x10x1 : SingletonAmericanBase<HSS34x10x1>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS34X10X1";
        public Length Height => new Length(34.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(31.20, LengthUnit.Inch);
        public Length FlatWidth => new Length(7.21, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS34x10x1() { }
    }
}
