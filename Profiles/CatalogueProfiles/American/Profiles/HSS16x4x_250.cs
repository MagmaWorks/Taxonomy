namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS16x4x_250 : SingletonAmericanBase<HSS16x4x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS16X4X.250";
        public Length Height => new Length(16.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(15.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(3.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS16x4x_250() { }
    }
}
