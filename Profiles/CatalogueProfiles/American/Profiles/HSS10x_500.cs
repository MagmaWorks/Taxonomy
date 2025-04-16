namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS10x_500 : SingletonAmericanBase<HSS10x_500>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS10X.500";
        public Length Diameter => new Length(10.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS10x_500() { }
    }
}
