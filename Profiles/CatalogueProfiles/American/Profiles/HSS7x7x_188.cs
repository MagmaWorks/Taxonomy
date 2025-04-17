namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS7x7x_188 : SingletonAmericanBase<HSS7x7x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS7X7X.188";
        public Length Height => new Length(7.00, LengthUnit.Inch);
        public Length Width => new Length(7.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(6.48, LengthUnit.Inch);
        public Length FlatWidth => new Length(6.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS7x7x_188() { }
    }
}
