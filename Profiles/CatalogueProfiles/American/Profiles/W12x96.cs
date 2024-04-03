using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x96 : SingletonAmericanBase<W12x96>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X96";
        public Length Height => new Length(12.70, LengthUnit.Inch);
        public Length Width => new Length(12.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.90, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.855, LengthUnit.Inch);

        public W12x96() { }
    }
}
