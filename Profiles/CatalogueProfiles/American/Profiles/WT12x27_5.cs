using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x27_5 : SingletonAmericanBase<WT12x27_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X27.5";
        public Length Height => new Length(11.80, LengthUnit.Inch);
        public Length Width => new Length(7.01, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.51, LengthUnit.Inch);
        public Length WebThickness => new Length(0.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.79, LengthUnit.Inch);

        public WT12x27_5() { }
    }
}
