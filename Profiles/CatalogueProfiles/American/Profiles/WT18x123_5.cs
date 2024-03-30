using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x123_5 : SingletonAmericanBase<WT18x123_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X123.5";
        public Length Height => new Length(18.30, LengthUnit.Inch);
        public Length Width => new Length(16.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.35, LengthUnit.Inch);
        public Length WebThickness => new Length(0.80, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.55, LengthUnit.Inch);

        public WT18x123_5() { }
    }
}
