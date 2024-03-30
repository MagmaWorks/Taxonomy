using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x96 : SingletonAmericanBase<WT9x96>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X96";
        public Length Height => new Length(10.20, LengthUnit.Inch);
        public Length Width => new Length(11.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.96, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.12, LengthUnit.Inch);

        public WT9x96() { }
    }
}
