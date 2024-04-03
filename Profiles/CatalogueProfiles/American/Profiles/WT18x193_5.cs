using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x193_5 : SingletonAmericanBase<WT18x193_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X193.5";
        public Length Height => new Length(19.50, LengthUnit.Inch);
        public Length Width => new Length(12.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.56, LengthUnit.Inch);
        public Length WebThickness => new Length(1.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.19, LengthUnit.Inch);

        public WT18x193_5() { }
    }
}
