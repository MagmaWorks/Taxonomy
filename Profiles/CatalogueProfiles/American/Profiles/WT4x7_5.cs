using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x7_5 : SingletonAmericanBase<WT4x7_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X7.5";
        public Length Height => new Length(4.06, LengthUnit.Inch);
        public Length Width => new Length(4.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.32, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.44, LengthUnit.Inch);

        public WT4x7_5() { }
    }
}
