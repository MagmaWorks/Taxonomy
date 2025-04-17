namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x18x_313 : SingletonAmericanBase<HSS22x18x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X18X.313";
        public Length Height => new Length(22.00, LengthUnit.Inch);
        public Length Width => new Length(18.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(21.10, LengthUnit.Inch);
        public Length FlatWidth => new Length(17.1, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS22x18x_313() { }
    }
}
