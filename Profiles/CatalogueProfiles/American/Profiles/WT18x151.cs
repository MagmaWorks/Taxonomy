using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x151 : SingletonAmericanBase<WT18x151>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X151";
        public Length Height => new Length(18.70, LengthUnit.Inch);
        public Length Width => new Length(16.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.68, LengthUnit.Inch);
        public Length WebThickness => new Length(0.95, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.245, LengthUnit.Inch);

        public WT18x151() { }
    }
}
