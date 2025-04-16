namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS28x1_000 : SingletonAmericanBase<HSS28x1_000>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS28X1.000";
        public Length Diameter => new Length(28.00, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS28x1_000() { }
    }
}
