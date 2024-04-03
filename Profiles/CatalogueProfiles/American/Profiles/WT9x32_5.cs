using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x32_5 : SingletonAmericanBase<WT9x32_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X32.5";
        public Length Height => new Length(9.18, LengthUnit.Inch);
        public Length Width => new Length(7.59, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.45, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.03, LengthUnit.Inch);

        public WT9x32_5() { }
    }
}
