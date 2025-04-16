namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS4x_220 : SingletonAmericanBase<HSS4x_220>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS4X.220";
        public Length Diameter => new Length(4.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.22, LengthUnit.Inch);

        public HSS4x_220() { }
    }
}
