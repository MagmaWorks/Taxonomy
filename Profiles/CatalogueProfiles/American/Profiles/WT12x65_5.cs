using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x65_5 : SingletonAmericanBase<WT12x65_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X65.5";
        public Length Height => new Length(12.20, LengthUnit.Inch);
        public Length Width => new Length(12.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.96, LengthUnit.Inch);
        public Length WebThickness => new Length(0.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.685, LengthUnit.Inch);

        public WT12x65_5() { }
    }
}
