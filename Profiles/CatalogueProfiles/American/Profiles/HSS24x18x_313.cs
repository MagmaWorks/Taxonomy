namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x18x_313 : SingletonAmericanBase<HSS24x18x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X18X.313";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(18.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(23.10, LengthUnit.Inch);
        public Length FlatWidth => new Length(17.1, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS24x18x_313() { }
    }
}
