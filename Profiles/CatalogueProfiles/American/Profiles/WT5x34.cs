using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x34 : SingletonAmericanBase<WT5x34>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X34";
        public Length Height => new Length(5.20, LengthUnit.Inch);
        public Length Width => new Length(10.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.77, LengthUnit.Inch);
        public Length WebThickness => new Length(0.47, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.545, LengthUnit.Inch);

        public WT5x34() { }
    }
}
