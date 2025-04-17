namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS2x1_1over2x_188 : SingletonAmericanBase<HSS2x1_1over2x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS2X1-1/2X.188";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(1.48, LengthUnit.Inch);
        public Length FlatWidth => new Length(0.98, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS2x1_1over2x_188() { }
    }
}
