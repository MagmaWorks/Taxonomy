using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x22_5 : SingletonAmericanBase<WT8x22_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X22.5";
        public Length Height => new Length(8.07, LengthUnit.Inch);
        public Length Width => new Length(7.04, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.1, LengthUnit.Inch);

        public WT8x22_5() { }
    }
}
