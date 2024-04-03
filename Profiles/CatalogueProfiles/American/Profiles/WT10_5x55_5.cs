using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x55_5 : SingletonAmericanBase<WT10_5x55_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X55.5";
        public Length Height => new Length(10.80, LengthUnit.Inch);
        public Length Width => new Length(12.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.42, LengthUnit.Inch);

        public WT10_5x55_5() { }
    }
}
