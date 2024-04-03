using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x124 : SingletonAmericanBase<WT10_5x124>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X124";
        public Length Height => new Length(11.90, LengthUnit.Inch);
        public Length Width => new Length(12.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.99, LengthUnit.Inch);
        public Length WebThickness => new Length(1.10, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.73, LengthUnit.Inch);

        public WT10_5x124() { }
    }
}
