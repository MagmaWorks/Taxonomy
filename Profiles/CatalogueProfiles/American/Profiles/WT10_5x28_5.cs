using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x28_5 : SingletonAmericanBase<WT10_5x28_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X28.5";
        public Length Height => new Length(10.50, LengthUnit.Inch);
        public Length Width => new Length(6.56, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.65, LengthUnit.Inch);
        public Length WebThickness => new Length(0.41, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.35, LengthUnit.Inch);

        public WT10_5x28_5() { }
    }
}
