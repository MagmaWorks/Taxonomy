using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x42 : SingletonAmericanBase<WT12x42>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X42";
        public Length Height => new Length(12.10, LengthUnit.Inch);
        public Length Width => new Length(9.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.77, LengthUnit.Inch);
        public Length WebThickness => new Length(0.47, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.005, LengthUnit.Inch);

        public WT12x42() { }
    }
}
