namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL2_1over2x1_1over2x3over16LLBB : SingletonAmericanBase<DoubleL2_1over2x1_1over2x3over16LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L2-1/2X1-1/2X3/16LLBB";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL2_1over2x1_1over2x3over16LLBB() { }
    }
}
