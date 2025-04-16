namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6_875x_375 : SingletonAmericanBase<HSS6_875x_375>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6.875X.375";
        public Length Diameter => new Length(6.88, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS6_875x_375() { }
    }
}
