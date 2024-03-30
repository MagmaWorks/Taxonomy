using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x53 : SingletonAmericanBase<WT6x53>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X53";
        public Length Height => new Length(6.45, LengthUnit.Inch);
        public Length Width => new Length(12.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.99, LengthUnit.Inch);
        public Length WebThickness => new Length(0.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.205, LengthUnit.Inch);

        public WT6x53() { }
    }
}
