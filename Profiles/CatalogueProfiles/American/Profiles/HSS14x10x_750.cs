namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x10x_750 : SingletonAmericanBase<HSS14x10x_750>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X10X.750";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(11.90, LengthUnit.Inch);
        public Length FlatWidth => new Length(7.91, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS14x10x_750() { }
    }
}
