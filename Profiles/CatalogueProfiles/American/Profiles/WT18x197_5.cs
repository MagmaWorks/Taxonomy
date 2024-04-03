using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x197_5 : SingletonAmericanBase<WT18x197_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X197.5";
        public Length Height => new Length(19.20, LengthUnit.Inch);
        public Length Width => new Length(16.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.20, LengthUnit.Inch);
        public Length WebThickness => new Length(1.22, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.05, LengthUnit.Inch);

        public WT18x197_5() { }
    }
}
