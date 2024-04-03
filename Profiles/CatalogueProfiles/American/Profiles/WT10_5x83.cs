using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x83 : SingletonAmericanBase<WT10_5x83>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X83";
        public Length Height => new Length(11.20, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.34, LengthUnit.Inch);

        public WT10_5x83() { }
    }
}
