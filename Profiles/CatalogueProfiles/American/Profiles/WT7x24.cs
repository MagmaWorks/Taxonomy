using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x24 : SingletonAmericanBase<WT7x24>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X24";
        public Length Height => new Length(6.90, LengthUnit.Inch);
        public Length Width => new Length(8.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.60, LengthUnit.Inch);
        public Length WebThickness => new Length(0.34, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.71, LengthUnit.Inch);

        public WT7x24() { }
    }
}
