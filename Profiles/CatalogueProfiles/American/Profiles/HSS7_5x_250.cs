namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS7_5x_250 : SingletonAmericanBase<HSS7_5x_250>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS7.5X.250";
        public Length Diameter => new Length(7.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS7_5x_250() { }
    }
}
