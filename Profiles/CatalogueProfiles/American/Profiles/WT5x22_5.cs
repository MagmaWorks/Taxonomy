using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x22_5 : SingletonAmericanBase<WT5x22_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X22.5";
        public Length Height => new Length(5.05, LengthUnit.Inch);
        public Length Width => new Length(8.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.62, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.93, LengthUnit.Inch);

        public WT5x22_5() { }
    }
}
