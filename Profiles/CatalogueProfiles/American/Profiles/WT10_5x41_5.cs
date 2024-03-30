using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x41_5 : SingletonAmericanBase<WT10_5x41_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X41.5";
        public Length Height => new Length(10.70, LengthUnit.Inch);
        public Length Width => new Length(8.36, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.84, LengthUnit.Inch);
        public Length WebThickness => new Length(0.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.58, LengthUnit.Inch);

        public WT10_5x41_5() { }
    }
}
