using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x25 : SingletonAmericanBase<WT10_5x25>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X25";
        public Length Height => new Length(10.40, LengthUnit.Inch);
        public Length Width => new Length(6.53, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.54, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.035, LengthUnit.Inch);

        public WT10_5x25() { }
    }
}
