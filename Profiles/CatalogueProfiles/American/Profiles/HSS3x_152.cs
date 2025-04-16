namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3x_152 : SingletonAmericanBase<HSS3x_152>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3X.152";
        public Length Diameter => new Length(3.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.15, LengthUnit.Inch);

        public HSS3x_152() { }
    }
}
