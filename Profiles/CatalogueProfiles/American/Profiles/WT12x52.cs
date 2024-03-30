using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x52 : SingletonAmericanBase<WT12x52>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X52";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(12.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.9, LengthUnit.Inch);

        public WT12x52() { }
    }
}
