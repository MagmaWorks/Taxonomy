namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL8x8x1_1over8x3over4 : SingletonAmericanBase<DoubleL8x8x1_1over8x3over4>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L8X8X1-1/8X3/4";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.13, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL8x8x1_1over8x3over4() { }
    }
}
