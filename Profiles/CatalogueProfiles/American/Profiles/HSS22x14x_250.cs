namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x14x_250 : SingletonAmericanBase<HSS22x14x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X14X.250";
        public Length Height => new Length(22.00, LengthUnit.Inch);
        public Length Width => new Length(14.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(21.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(13.3, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS22x14x_250() { }
    }
}
