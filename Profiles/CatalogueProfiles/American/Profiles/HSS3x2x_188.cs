namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3x2x_188 : SingletonAmericanBase<HSS3x2x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3X2X.188";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(2.48, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS3x2x_188() { }
    }
}
