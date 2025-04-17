namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3x3x3over16x3over4 : SingletonAmericanBase<DoubleL3x3x3over16x3over4>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3X3X3/16X3/4";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL3x3x3over16x3over4() { }
    }
}
