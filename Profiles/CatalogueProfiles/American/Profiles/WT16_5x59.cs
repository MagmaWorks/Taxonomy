using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x59 : SingletonAmericanBase<WT16_5x59>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X59";
        public Length Height => new Length(16.40, LengthUnit.Inch);
        public Length Width => new Length(11.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.74, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(14.96, LengthUnit.Inch);

        public WT16_5x59() { }
    }
}
