using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x50_5 : SingletonAmericanBase<WT10_5x50_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X50.5";
        public Length Height => new Length(10.70, LengthUnit.Inch);
        public Length Width => new Length(12.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.80, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.6, LengthUnit.Inch);

        public WT10_5x50_5() { }
    }
}
