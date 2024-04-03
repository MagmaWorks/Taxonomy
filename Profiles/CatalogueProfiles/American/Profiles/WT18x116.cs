using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x116 : SingletonAmericanBase<WT18x116>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X116";
        public Length Height => new Length(18.60, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.28, LengthUnit.Inch);

        public WT18x116() { }
    }
}
