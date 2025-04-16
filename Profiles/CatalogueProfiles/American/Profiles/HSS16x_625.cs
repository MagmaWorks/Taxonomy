namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS16x_625 : SingletonAmericanBase<HSS16x_625>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS16X.625";
        public Length Diameter => new Length(16.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS16x_625() { }
    }
}
