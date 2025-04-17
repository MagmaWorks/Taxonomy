namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x_375 : SingletonAmericanBase<HSS22x_375>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X.375";
        public Length Diameter => new Length(22.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS22x_375() { }
    }
}
