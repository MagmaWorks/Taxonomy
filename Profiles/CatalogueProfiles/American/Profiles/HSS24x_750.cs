namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x_750 : SingletonAmericanBase<HSS24x_750>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X.750";
        public Length Diameter => new Length(24.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS24x_750() { }
    }
}
