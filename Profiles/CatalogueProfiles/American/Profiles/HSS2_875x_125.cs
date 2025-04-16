namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS2_875x_125 : SingletonAmericanBase<HSS2_875x_125>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS2.875X.125";
        public Length Diameter => new Length(2.88, LengthUnit.Inch);
        public Length Thickness => new Length(0.13, LengthUnit.Inch);

        public HSS2_875x_125() { }
    }
}
