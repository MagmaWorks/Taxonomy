namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS7x_500 : SingletonAmericanBase<HSS7x_500>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS7X.500";
        public Length Diameter => new Length(7.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS7x_500() { }
    }
}
