using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x110_5 : SingletonAmericanBase<WT16_5x110_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X110.5";
        public Length Height => new Length(17.00, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.28, LengthUnit.Inch);
        public Length WebThickness => new Length(0.78, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.45, LengthUnit.Inch);

        public WT16_5x110_5() { }
    }
}
