namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x_313 : SingletonAmericanBase<HSS24x_313>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X.313";
        public Length Diameter => new Length(24.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS24x_313() { }
    }
}
