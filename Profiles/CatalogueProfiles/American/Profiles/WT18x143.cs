using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x143 : SingletonAmericanBase<WT18x143>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X143";
        public Length Height => new Length(18.90, LengthUnit.Inch);
        public Length Width => new Length(12.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.93, LengthUnit.Inch);
        public Length WebThickness => new Length(1.06, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.22, LengthUnit.Inch);

        public WT18x143() { }
    }
}
