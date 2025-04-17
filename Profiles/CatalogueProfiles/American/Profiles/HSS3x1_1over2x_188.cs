namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3x1_1over2x_188 : SingletonAmericanBase<HSS3x1_1over2x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3X1-1/2X.188";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(2.48, LengthUnit.Inch);
        public Length FlatWidth => new Length(0.98, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS3x1_1over2x_188() { }
    }
}
