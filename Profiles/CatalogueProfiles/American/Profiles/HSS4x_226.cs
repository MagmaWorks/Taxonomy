namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS4x_226 : SingletonAmericanBase<HSS4x_226>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS4X.226";
        public Length Diameter => new Length(4.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.23, LengthUnit.Inch);

        public HSS4x_226() { }
    }
}
