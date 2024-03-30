using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x9_5 : SingletonAmericanBase<WT6x9_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X9.5";
        public Length Height => new Length(6.08, LengthUnit.Inch);
        public Length Width => new Length(4.01, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.35, LengthUnit.Inch);
        public Length WebThickness => new Length(0.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public WT6x9_5() { }
    }
}
