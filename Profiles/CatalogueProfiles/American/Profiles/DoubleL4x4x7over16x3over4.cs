namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL4x4x7over16x3over4 : SingletonAmericanBase<DoubleL4x4x7over16x3over4>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L4X4X7/16X3/4";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL4x4x7over16x3over4() { }
    }
}
