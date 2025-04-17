namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6_625x_312 : SingletonAmericanBase<HSS6_625x_312>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6.625X.312";
        public Length Diameter => new Length(6.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS6_625x_312() { }
    }
}
