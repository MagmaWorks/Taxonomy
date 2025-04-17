namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x_625 : SingletonAmericanBase<HSS14x_625>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X.625";
        public Length Diameter => new Length(14.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS14x_625() { }
    }
}
