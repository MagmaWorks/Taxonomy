namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS10x_250 : SingletonAmericanBase<HSS10x_250>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS10X.250";
        public Length Diameter => new Length(10.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS10x_250() { }
    }
}
