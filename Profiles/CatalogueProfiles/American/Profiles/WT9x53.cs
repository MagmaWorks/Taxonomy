using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x53 : SingletonAmericanBase<WT9x53>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X53";
        public Length Height => new Length(9.37, LengthUnit.Inch);
        public Length Width => new Length(11.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.94, LengthUnit.Inch);
        public Length WebThickness => new Length(0.59, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.03, LengthUnit.Inch);

        public WT9x53() { }
    }
}
