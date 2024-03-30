using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x46_5 : SingletonAmericanBase<WT10_5x46_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X46.5";
        public Length Height => new Length(10.80, LengthUnit.Inch);
        public Length Width => new Length(8.42, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.93, LengthUnit.Inch);
        public Length WebThickness => new Length(0.58, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.49, LengthUnit.Inch);

        public WT10_5x46_5() { }
    }
}
