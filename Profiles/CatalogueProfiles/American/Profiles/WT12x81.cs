using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x81 : SingletonAmericanBase<WT12x81>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X81";
        public Length Height => new Length(12.50, LengthUnit.Inch);
        public Length Width => new Length(13.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.22, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.78, LengthUnit.Inch);

        public WT12x81() { }
    }
}
