namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x14x_625 : SingletonAmericanBase<HSS24x14x_625>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X14X.625";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(14.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(22.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(12.3, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS24x14x_625() { }
    }
}
