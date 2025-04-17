namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS30x10x_875 : SingletonAmericanBase<HSS30x10x_875>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS30X10X.875";
        public Length Height => new Length(30.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(27.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(7.56, LengthUnit.Inch);
        public Length Thickness => new Length(0.88, LengthUnit.Inch);

        public HSS30x10x_875() { }
    }
}
