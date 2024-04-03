using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x6 : SingletonAmericanBase<WT5x6>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X6";
        public Length Height => new Length(4.94, LengthUnit.Inch);
        public Length Width => new Length(3.96, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.21, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.43, LengthUnit.Inch);

        public WT5x6() { }
    }
}
