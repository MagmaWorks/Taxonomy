using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x100_5 : SingletonAmericanBase<WT10_5x100_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X100.5";
        public Length Height => new Length(11.50, LengthUnit.Inch);
        public Length Width => new Length(12.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.91, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.715, LengthUnit.Inch);

        public WT10_5x100_5() { }
    }
}
