namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS10x4x_375 : SingletonAmericanBase<HSS10x4x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS10X4X.375";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(8.95, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.95, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS10x4x_375() { }
    }
}
