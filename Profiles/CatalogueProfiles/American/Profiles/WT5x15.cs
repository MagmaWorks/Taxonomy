using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x15 : SingletonAmericanBase<WT5x15>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X15";
        public Length Height => new Length(5.24, LengthUnit.Inch);
        public Length Width => new Length(5.81, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.51, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.945, LengthUnit.Inch);

        public WT5x15() { }
    }
}
