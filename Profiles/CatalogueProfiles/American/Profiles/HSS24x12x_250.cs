namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x12x_250 : SingletonAmericanBase<HSS24x12x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X12X.250";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(23.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(11.3, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS24x12x_250() { }
    }
}
