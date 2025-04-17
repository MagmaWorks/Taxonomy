namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS16x4x_188 : SingletonAmericanBase<HSS16x4x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS16X4X.188";
        public Length Height => new Length(16.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(15.50, LengthUnit.Inch);
        public Length FlatWidth => new Length(3.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS16x4x_188() { }
    }
}
