using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x61 : SingletonAmericanBase<WT10_5x61>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X61";
        public Length Height => new Length(10.80, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.96, LengthUnit.Inch);
        public Length WebThickness => new Length(0.60, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.44, LengthUnit.Inch);

        public WT10_5x61() { }
    }
}
