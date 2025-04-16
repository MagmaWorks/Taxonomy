namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6x3x_250 : SingletonAmericanBase<HSS6x3x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6X3X.250";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(5.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS6x3x_250() { }
    }
}
