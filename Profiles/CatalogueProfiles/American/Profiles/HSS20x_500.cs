namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS20x_500 : SingletonAmericanBase<HSS20x_500>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS20X.500";
        public Length Diameter => new Length(20.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS20x_500() { }
    }
}
