using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x51_5 : SingletonAmericanBase<WT12x51_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X51.5";
        public Length Height => new Length(12.30, LengthUnit.Inch);
        public Length Width => new Length(9.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.98, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.82, LengthUnit.Inch);

        public WT12x51_5() { }
    }
}
