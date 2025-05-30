namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS28x_750 : SingletonAmericanBase<HSS28x_750>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS28X.750";
        public Length Diameter => new Length(28.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS28x_750() { }
    }
}
