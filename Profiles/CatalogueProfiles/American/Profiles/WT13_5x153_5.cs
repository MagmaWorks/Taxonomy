using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x153_5 : SingletonAmericanBase<WT13_5x153_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X153.5";
        public Length Height => new Length(14.80, LengthUnit.Inch);
        public Length Width => new Length(14.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.09, LengthUnit.Inch);
        public Length WebThickness => new Length(1.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.74, LengthUnit.Inch);

        public WT13_5x153_5() { }
    }
}
