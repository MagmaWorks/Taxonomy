using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x65 : SingletonAmericanBase<WT16_5x65>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X65";
        public Length Height => new Length(16.50, LengthUnit.Inch);
        public Length Width => new Length(11.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.86, LengthUnit.Inch);
        public Length WebThickness => new Length(0.58, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.9, LengthUnit.Inch);

        public WT16_5x65() { }
    }
}
