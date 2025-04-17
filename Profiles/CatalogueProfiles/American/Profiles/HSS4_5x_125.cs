namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS4_5x_125 : SingletonAmericanBase<HSS4_5x_125>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS4.5X.125";
        public Length Diameter => new Length(4.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.13, LengthUnit.Inch);

        public HSS4_5x_125() { }
    }
}
