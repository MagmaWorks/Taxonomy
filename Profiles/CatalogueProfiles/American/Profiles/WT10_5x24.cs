using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x24 : SingletonAmericanBase<WT10_5x24>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X24";
        public Length Height => new Length(10.30, LengthUnit.Inch);
        public Length Width => new Length(8.14, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.37, LengthUnit.Inch);

        public WT10_5x24() { }
    }
}
