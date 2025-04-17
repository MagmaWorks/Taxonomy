namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6x4x_250 : SingletonAmericanBase<HSS6x4x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6X4X.250";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(5.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(3.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS6x4x_250() { }
    }
}
