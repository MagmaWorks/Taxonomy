using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x24 : SingletonAmericanBase<WT4x24>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X24";
        public Length Height => new Length(4.25, LengthUnit.Inch);
        public Length Width => new Length(8.11, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.69, LengthUnit.Inch);
        public Length WebThickness => new Length(0.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.775, LengthUnit.Inch);

        public WT4x24() { }
    }
}