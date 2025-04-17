namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x14x_750 : SingletonAmericanBase<HSS24x14x_750>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X14X.750";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(14.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(21.90, LengthUnit.Inch);
        public Length FlatWidth => new Length(11.9, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS24x14x_750() { }
    }
}
