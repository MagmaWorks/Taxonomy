namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS13_375x_313 : SingletonAmericanBase<HSS13_375x_313>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS13.375X.313";
        public Length Diameter => new Length(13.40, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS13_375x_313() { }
    }
}
