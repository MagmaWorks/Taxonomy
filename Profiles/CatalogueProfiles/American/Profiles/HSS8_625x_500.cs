namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS8_625x_500 : SingletonAmericanBase<HSS8_625x_500>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS8.625X.500";
        public Length Diameter => new Length(8.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS8_625x_500() { }
    }
}
