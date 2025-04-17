namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x10x_375 : SingletonAmericanBase<HSS14x10x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X10X.375";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(13.00, LengthUnit.Inch);
        public Length FlatWidth => new Length(8.95, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS14x10x_375() { }
    }
}
