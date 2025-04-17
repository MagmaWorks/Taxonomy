namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS12x_500 : SingletonAmericanBase<HSS12x_500>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS12X.500";
        public Length Diameter => new Length(12.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS12x_500() { }
    }
}
