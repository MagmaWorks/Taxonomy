namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS5_563x_258 : SingletonAmericanBase<HSS5_563x_258>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS5.563X.258";
        public Length Diameter => new Length(5.56, LengthUnit.Inch);
        public Length Thickness => new Length(0.26, LengthUnit.Inch);

        public HSS5_563x_258() { }
    }
}
