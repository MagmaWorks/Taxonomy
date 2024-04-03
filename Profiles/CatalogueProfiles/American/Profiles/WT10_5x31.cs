using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x31 : SingletonAmericanBase<WT10_5x31>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X31";
        public Length Height => new Length(10.50, LengthUnit.Inch);
        public Length Width => new Length(8.24, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.62, LengthUnit.Inch);
        public Length WebThickness => new Length(0.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.38, LengthUnit.Inch);

        public WT10_5x31() { }
    }
}
