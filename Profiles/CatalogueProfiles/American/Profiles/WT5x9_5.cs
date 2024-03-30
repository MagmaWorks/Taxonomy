using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x9_5 : SingletonAmericanBase<WT5x9_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X9.5";
        public Length Height => new Length(5.12, LengthUnit.Inch);
        public Length Width => new Length(4.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.40, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.185, LengthUnit.Inch);

        public WT5x9_5() { }
    }
}
