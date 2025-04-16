namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x14x1 : SingletonAmericanBase<HSS14x14x1>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X14X1";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(14.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(11.20, LengthUnit.Inch);
        public Length FlatWidth => new Length(11.2, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS14x14x1() { }
    }
}
