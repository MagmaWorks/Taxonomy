namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS34x10x_875 : SingletonAmericanBase<HSS34x10x_875>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS34X10X.875";
        public Length Height => new Length(34.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(31.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(7.56, LengthUnit.Inch);
        public Length Thickness => new Length(0.88, LengthUnit.Inch);

        public HSS34x10x_875() { }
    }
}
