namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x14x_750 : SingletonAmericanBase<HSS14x14x_750>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X14X.750";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(14.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(11.90, LengthUnit.Inch);
        public Length FlatWidth => new Length(11.90, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS14x14x_750() { }
    }
}
