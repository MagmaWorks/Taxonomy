namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x18x_500 : SingletonAmericanBase<HSS22x18x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X18X.500";
        public Length Height => new Length(22.00, LengthUnit.Inch);
        public Length Width => new Length(18.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(20.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(16.6, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS22x18x_500() { }
    }
}
