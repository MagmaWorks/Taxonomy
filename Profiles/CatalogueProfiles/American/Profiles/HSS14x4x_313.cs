namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x4x_313 : SingletonAmericanBase<HSS14x4x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X4X.313";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(13.10, LengthUnit.Inch);
        public Length FlatWidth => new Length(3.13, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS14x4x_313() { }
    }
}
