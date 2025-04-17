namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3_1over2x3_1over2x3over8x3over4 : SingletonAmericanBase<DoubleL3_1over2x3_1over2x3over8x3over4>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3-1/2X3-1/2X3/8X3/4";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL3_1over2x3_1over2x3over8x3over4() { }
    }
}
