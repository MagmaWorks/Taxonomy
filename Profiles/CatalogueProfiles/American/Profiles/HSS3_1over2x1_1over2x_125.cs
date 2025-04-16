namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3_1over2x1_1over2x_125 : SingletonAmericanBase<HSS3_1over2x1_1over2x_125>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3-1/2X1-1/2X.125";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(3.15, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.15, LengthUnit.Inch);
        public Length Thickness => new Length(0.13, LengthUnit.Inch);

        public HSS3_1over2x1_1over2x_125() { }
    }
}
