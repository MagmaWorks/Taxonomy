using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x88 : SingletonAmericanBase<WT12x88>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X88";
        public Length Height => new Length(12.60, LengthUnit.Inch);
        public Length Width => new Length(12.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.34, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.76, LengthUnit.Inch);

        public WT12x88() { }
    }
}
