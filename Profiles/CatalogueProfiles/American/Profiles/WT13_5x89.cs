using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x89 : SingletonAmericanBase<WT13_5x89>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X89";
        public Length Height => new Length(13.90, LengthUnit.Inch);
        public Length Width => new Length(14.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.73, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.705, LengthUnit.Inch);

        public WT13_5x89() { }
    }
}
