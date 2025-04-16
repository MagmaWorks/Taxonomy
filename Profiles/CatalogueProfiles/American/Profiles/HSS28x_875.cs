namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS28x_875 : SingletonAmericanBase<HSS28x_875>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS28X.875";
        public Length Diameter => new Length(28.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.88, LengthUnit.Inch);

        public HSS28x_875() { }
    }
}
