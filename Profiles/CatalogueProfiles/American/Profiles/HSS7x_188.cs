namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS7x_188 : SingletonAmericanBase<HSS7x_188>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS7X.188";
        public Length Diameter => new Length(7.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS7x_188() { }
    }
}
