namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS16x6x_188 : SingletonAmericanBase<HSS16x6x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS16X6X.188";
        public Length Height => new Length(16.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(15.50, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS16x6x_188() { }
    }
}
