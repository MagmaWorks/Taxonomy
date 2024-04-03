using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x14 : SingletonAmericanBase<WT4x14>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X14";
        public Length Height => new Length(4.03, LengthUnit.Inch);
        public Length Width => new Length(6.54, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.47, LengthUnit.Inch);
        public Length WebThickness => new Length(0.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.17, LengthUnit.Inch);

        public WT4x14() { }
    }
}
