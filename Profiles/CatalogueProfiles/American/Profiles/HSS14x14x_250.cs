namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x14x_250 : SingletonAmericanBase<HSS14x14x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X14X.250";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(14.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(13.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(13.3, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS14x14x_250() { }
    }
}
