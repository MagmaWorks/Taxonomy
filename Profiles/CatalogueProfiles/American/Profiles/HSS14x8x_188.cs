namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x8x_188 : SingletonAmericanBase<HSS14x8x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X8X.188";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(13.50, LengthUnit.Inch);
        public Length FlatWidth => new Length(7.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS14x8x_188() { }
    }
}
