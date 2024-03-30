using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT3x4_5 : SingletonAmericanBase<WT3x4_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT3X4.5";
        public Length Height => new Length(2.95, LengthUnit.Inch);
        public Length Width => new Length(3.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.22, LengthUnit.Inch);
        public Length WebThickness => new Length(0.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.415, LengthUnit.Inch);

        public WT3x4_5() { }
    }
}
