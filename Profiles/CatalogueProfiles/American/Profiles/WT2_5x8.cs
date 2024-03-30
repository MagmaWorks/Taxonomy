using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT2_5x8 : SingletonAmericanBase<WT2_5x8>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT2.5X8";
        public Length Height => new Length(2.51, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.72, LengthUnit.Inch);

        public WT2_5x8() { }
    }
}
