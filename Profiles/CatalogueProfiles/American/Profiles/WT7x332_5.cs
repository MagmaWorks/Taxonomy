using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x332_5 : SingletonAmericanBase<WT7x332_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X332.5";
        public Length Height => new Length(10.80, LengthUnit.Inch);
        public Length Width => new Length(17.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.52, LengthUnit.Inch);
        public Length WebThickness => new Length(2.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.315, LengthUnit.Inch);

        public WT7x332_5() { }
    }
}
