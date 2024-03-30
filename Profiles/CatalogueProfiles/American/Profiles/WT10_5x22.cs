using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x22 : SingletonAmericanBase<WT10_5x22>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X22";
        public Length Height => new Length(10.30, LengthUnit.Inch);
        public Length Width => new Length(6.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.45, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.125, LengthUnit.Inch);

        public WT10_5x22() { }
    }
}
