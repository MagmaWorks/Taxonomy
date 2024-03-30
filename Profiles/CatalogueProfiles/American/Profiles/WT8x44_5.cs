using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x44_5 : SingletonAmericanBase<WT8x44_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X44.5";
        public Length Height => new Length(8.38, LengthUnit.Inch);
        public Length Width => new Length(10.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.53, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.655, LengthUnit.Inch);

        public WT8x44_5() { }
    }
}
