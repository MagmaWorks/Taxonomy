namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3_5x_203 : SingletonAmericanBase<HSS3_5x_203>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3.5X.203";
        public Length Diameter => new Length(3.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.20, LengthUnit.Inch);

        public HSS3_5x_203() { }
    }
}
