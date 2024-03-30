using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x193_5 : SingletonAmericanBase<WT16_5x193_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X193.5";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(16.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.28, LengthUnit.Inch);
        public Length WebThickness => new Length(1.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.4, LengthUnit.Inch);

        public WT16_5x193_5() { }
    }
}
