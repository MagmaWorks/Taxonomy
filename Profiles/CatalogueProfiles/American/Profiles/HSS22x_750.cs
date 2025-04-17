namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x_750 : SingletonAmericanBase<HSS22x_750>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X.750";
        public Length Diameter => new Length(22.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS22x_750() { }
    }
}
