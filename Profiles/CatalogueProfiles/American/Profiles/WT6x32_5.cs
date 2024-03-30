using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x32_5 : SingletonAmericanBase<WT6x32_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X32.5";
        public Length Height => new Length(6.06, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.61, LengthUnit.Inch);
        public Length WebThickness => new Length(0.39, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.605, LengthUnit.Inch);

        public WT6x32_5() { }
    }
}
