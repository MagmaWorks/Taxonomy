namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3_1over2x2x_188 : SingletonAmericanBase<HSS3_1over2x2x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3-1/2X2X.188";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(2.98, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS3_1over2x2x_188() { }
    }
}
