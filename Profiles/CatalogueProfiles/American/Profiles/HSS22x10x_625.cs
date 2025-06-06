namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x10x_625 : SingletonAmericanBase<HSS22x10x_625>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X10X.625";
        public Length Height => new Length(22.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(20.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(8.26, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS22x10x_625() { }
    }
}
