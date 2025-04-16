namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS5x_188 : SingletonAmericanBase<HSS5x_188>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS5X.188";
        public Length Diameter => new Length(5.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS5x_188() { }
    }
}
