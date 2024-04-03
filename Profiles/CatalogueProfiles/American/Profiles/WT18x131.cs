using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x131 : SingletonAmericanBase<WT18x131>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X131";
        public Length Height => new Length(18.40, LengthUnit.Inch);
        public Length Width => new Length(16.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.84, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.01, LengthUnit.Inch);

        public WT18x131() { }
    }
}
