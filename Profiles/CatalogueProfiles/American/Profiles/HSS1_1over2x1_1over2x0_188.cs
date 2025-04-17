namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS1_1over2x1_1over2x0_188 : SingletonAmericanBase<HSS1_1over2x1_1over2x0_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS1-1/2X1-1/2X0.188";
        public Length Height => new Length(1.50, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(0.98, LengthUnit.Inch);
        public Length FlatWidth => new Length(0.978, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS1_1over2x1_1over2x0_188() { }
    }
}
