using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x111_5 : SingletonAmericanBase<WT10_5x111_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X111.5";
        public Length Height => new Length(11.70, LengthUnit.Inch);
        public Length Width => new Length(12.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.79, LengthUnit.Inch);
        public Length WebThickness => new Length(1.00, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.88, LengthUnit.Inch);

        public WT10_5x111_5() { }
    }
}
