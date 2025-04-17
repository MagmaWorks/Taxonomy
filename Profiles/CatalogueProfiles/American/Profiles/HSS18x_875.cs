namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS18x_875 : SingletonAmericanBase<HSS18x_875>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS18X.875";
        public Length Diameter => new Length(18.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.88, LengthUnit.Inch);

        public HSS18x_875() { }
    }
}
