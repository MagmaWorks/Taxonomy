namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3x3x_125 : SingletonAmericanBase<HSS3x3x_125>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3X3X.125";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(2.65, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.65, LengthUnit.Inch);
        public Length Thickness => new Length(0.13, LengthUnit.Inch);

        public HSS3x3x_125() { }
    }
}
