namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS12x_250 : SingletonAmericanBase<HSS12x_250>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS12X.250";
        public Length Diameter => new Length(12.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS12x_250() { }
    }
}
