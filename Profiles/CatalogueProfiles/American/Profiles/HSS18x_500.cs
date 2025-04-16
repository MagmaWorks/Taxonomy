namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS18x_500 : SingletonAmericanBase<HSS18x_500>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS18X.500";
        public Length Diameter => new Length(18.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS18x_500() { }
    }
}
