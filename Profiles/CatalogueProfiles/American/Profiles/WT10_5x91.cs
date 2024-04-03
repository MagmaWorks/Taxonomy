using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x91 : SingletonAmericanBase<WT10_5x91>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X91";
        public Length Height => new Length(11.40, LengthUnit.Inch);
        public Length Width => new Length(12.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.48, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.42, LengthUnit.Inch);

        public WT10_5x91() { }
    }
}
