namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS12_75x_750 : SingletonAmericanBase<HSS12_75x_750>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS12.75X.750";
        public Length Diameter => new Length(12.80, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS12_75x_750() { }
    }
}
