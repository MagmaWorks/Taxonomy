namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x22x_750 : SingletonAmericanBase<HSS22x22x_750>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X22X.750";
        public Length Height => new Length(22.00, LengthUnit.Inch);
        public Length Width => new Length(22.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(19.90, LengthUnit.Inch);
        public Length FlatWidth => new Length(19.90, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS22x22x_750() { }
    }
}
