namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS12x_375 : SingletonAmericanBase<HSS12x_375>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS12X.375";
        public Length Diameter => new Length(12.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS12x_375() { }
    }
}
