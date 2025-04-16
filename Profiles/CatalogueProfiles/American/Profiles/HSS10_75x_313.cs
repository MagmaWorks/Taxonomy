namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS10_75x_313 : SingletonAmericanBase<HSS10_75x_313>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS10.75X.313";
        public Length Diameter => new Length(10.80, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS10_75x_313() { }
    }
}
