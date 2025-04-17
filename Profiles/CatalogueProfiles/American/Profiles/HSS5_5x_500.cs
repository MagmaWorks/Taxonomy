namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS5_5x_500 : SingletonAmericanBase<HSS5_5x_500>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS5.5X.500";
        public Length Diameter => new Length(5.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS5_5x_500() { }
    }
}
