namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6x_500 : SingletonAmericanBase<HSS6x_500>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6X.500";
        public Length Diameter => new Length(6.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS6x_500() { }
    }
}
