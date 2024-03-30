using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x17_5 : SingletonAmericanBase<WT4x17_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X17.5";
        public Length Height => new Length(4.06, LengthUnit.Inch);
        public Length Width => new Length(8.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.965, LengthUnit.Inch);

        public WT4x17_5() { }
    }
}
