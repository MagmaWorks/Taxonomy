namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x12x_875 : SingletonAmericanBase<HSS24x12x_875>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X12X.875";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(21.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(9.56, LengthUnit.Inch);
        public Length Thickness => new Length(0.88, LengthUnit.Inch);

        public HSS24x12x_875() { }
    }
}
