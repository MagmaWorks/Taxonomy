namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3_1over2x2_1over2x_375 : SingletonAmericanBase<HSS3_1over2x2_1over2x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3-1/2X2-1/2X.375";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(2.45, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.45, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS3_1over2x2_1over2x_375() { }
    }
}
