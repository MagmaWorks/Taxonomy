using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x96 : SingletonAmericanBase<WT12x96>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X96";
        public Length Height => new Length(12.70, LengthUnit.Inch);
        public Length Width => new Length(13.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.46, LengthUnit.Inch);
        public Length WebThickness => new Length(0.81, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.74, LengthUnit.Inch);

        public WT12x96() { }
    }
}
