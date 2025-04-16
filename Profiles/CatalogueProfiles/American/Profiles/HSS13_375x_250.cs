namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS13_375x_250 : SingletonAmericanBase<HSS13_375x_250>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS13.375X.250";
        public Length Diameter => new Length(13.40, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS13_375x_250() { }
    }
}
