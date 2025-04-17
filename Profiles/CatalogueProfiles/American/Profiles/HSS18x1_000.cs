namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS18x1_000 : SingletonAmericanBase<HSS18x1_000>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS18X1.000";
        public Length Diameter => new Length(18.00, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS18x1_000() { }
    }
}
