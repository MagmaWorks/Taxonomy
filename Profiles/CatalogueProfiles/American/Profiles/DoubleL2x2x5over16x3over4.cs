namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL2x2x5over16x3over4 : SingletonAmericanBase<DoubleL2x2x5over16x3over4>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L2X2X5/16X3/4";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL2x2x5over16x3over4() { }
    }
}
