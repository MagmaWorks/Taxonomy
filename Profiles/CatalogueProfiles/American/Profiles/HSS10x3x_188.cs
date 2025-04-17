namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS10x3x_188 : SingletonAmericanBase<HSS10x3x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS10X3X.188";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(9.48, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS10x3x_188() { }
    }
}
