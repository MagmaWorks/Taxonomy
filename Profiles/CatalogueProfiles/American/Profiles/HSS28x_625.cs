namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS28x_625 : SingletonAmericanBase<HSS28x_625>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS28X.625";
        public Length Diameter => new Length(28.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS28x_625() { }
    }
}
