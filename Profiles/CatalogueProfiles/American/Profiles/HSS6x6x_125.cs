namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6x6x_125 : SingletonAmericanBase<HSS6x6x_125>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6X6X.125";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(5.65, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.65, LengthUnit.Inch);
        public Length Thickness => new Length(0.13, LengthUnit.Inch);

        public HSS6x6x_125() { }
    }
}
