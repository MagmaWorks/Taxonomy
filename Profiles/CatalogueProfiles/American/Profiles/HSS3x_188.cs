namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3x_188 : SingletonAmericanBase<HSS3x_188>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3X.188";
        public Length Diameter => new Length(3.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.19, LengthUnit.Inch);

        public HSS3x_188() { }
    }
}
