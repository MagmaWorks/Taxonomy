using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x10_5 : SingletonAmericanBase<WT4x10_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X10.5";
        public Length Height => new Length(4.14, LengthUnit.Inch);
        public Length Width => new Length(5.27, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.40, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.81, LengthUnit.Inch);

        public WT4x10_5() { }
    }
}
