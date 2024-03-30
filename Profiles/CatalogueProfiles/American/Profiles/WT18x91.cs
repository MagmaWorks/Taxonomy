using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x91 : SingletonAmericanBase<WT18x91>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X91";
        public Length Height => new Length(18.20, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.18, LengthUnit.Inch);
        public Length WebThickness => new Length(0.73, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.755, LengthUnit.Inch);

        public WT18x91() { }
    }
}
