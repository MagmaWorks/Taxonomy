namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6x5x_250 : SingletonAmericanBase<HSS6x5x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6X5X.250";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(5.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(4.30, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS6x5x_250() { }
    }
}
