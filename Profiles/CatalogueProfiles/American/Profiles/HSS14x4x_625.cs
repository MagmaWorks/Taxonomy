namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x4x_625 : SingletonAmericanBase<HSS14x4x_625>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X4X.625";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(12.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.26, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS14x4x_625() { }
    }
}
