namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS2_1over2x1x_188 : SingletonAmericanBase<HSS2_1over2x1x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS2-1/2X1X.188";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(1.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(1.98, LengthUnit.Inch);
        public Length FlatWidth => new Length(0.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS2_1over2x1x_188() { }
    }
}
