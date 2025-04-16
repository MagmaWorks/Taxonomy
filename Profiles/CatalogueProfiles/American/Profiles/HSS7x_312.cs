namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS7x_312 : SingletonAmericanBase<HSS7x_312>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS7X.312";
        public Length Diameter => new Length(7.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS7x_312() { }
    }
}
