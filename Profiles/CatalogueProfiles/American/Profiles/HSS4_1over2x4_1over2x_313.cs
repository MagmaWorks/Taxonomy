namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS4_1over2x4_1over2x_313 : SingletonAmericanBase<HSS4_1over2x4_1over2x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS4-1/2X4-1/2X.313";
        public Length Height => new Length(4.50, LengthUnit.Inch);
        public Length Width => new Length(4.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(3.63, LengthUnit.Inch);
        public Length FlatWidth => new Length(3.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS4_1over2x4_1over2x_313() { }
    }
}
