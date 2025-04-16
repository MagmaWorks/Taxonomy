namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS5_563x_375 : SingletonAmericanBase<HSS5_563x_375>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS5.563X.375";
        public Length Diameter => new Length(5.56, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS5_563x_375() { }
    }
}
