using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x29 : SingletonAmericanBase<WT4x29>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X29";
        public Length Height => new Length(4.38, LengthUnit.Inch);
        public Length Width => new Length(8.22, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.81, LengthUnit.Inch);
        public Length WebThickness => new Length(0.51, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.655, LengthUnit.Inch);

        public WT4x29() { }
    }
}
