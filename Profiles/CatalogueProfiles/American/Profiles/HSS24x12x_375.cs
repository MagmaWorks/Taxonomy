namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x12x_375 : SingletonAmericanBase<HSS24x12x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X12X.375";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(23.00, LengthUnit.Inch);
        public Length FlatWidth => new Length(11.0, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS24x12x_375() { }
    }
}
