namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS26x_500 : SingletonAmericanBase<HSS26x_500>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS26X.500";
        public Length Diameter => new Length(26.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS26x_500() { }
    }
}
