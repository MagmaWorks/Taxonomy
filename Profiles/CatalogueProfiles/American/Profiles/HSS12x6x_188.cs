namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS12x6x_188 : SingletonAmericanBase<HSS12x6x_188>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS12X6X.188";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(11.50, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.48, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS12x6x_188() { }
    }
}
