using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x22_5 : SingletonAmericanBase<WT6x22_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X22.5";
        public Length Height => new Length(6.03, LengthUnit.Inch);
        public Length Width => new Length(8.05, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.58, LengthUnit.Inch);
        public Length WebThickness => new Length(0.34, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.775, LengthUnit.Inch);

        public WT6x22_5() { }
    }
}
