namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS13_375x_188 : SingletonAmericanBase<HSS13_375x_188>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS13.375X.188";
        public Length Diameter => new Length(13.40, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS13_375x_188() { }
    }
}
