namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x10x_250 : SingletonAmericanBase<HSS14x10x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X10X.250";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(13.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(9.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS14x10x_250() { }
    }
}
