namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL2_1over2x2_1over2x5over16x3over8 : SingletonAmericanBase<DoubleL2_1over2x2_1over2x5over16x3over8>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L2-1/2X2-1/2X5/16X3/8";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL2_1over2x2_1over2x5over16x3over8() { }
    }
}
