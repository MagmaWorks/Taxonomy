using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT2_5x9_5 : SingletonAmericanBase<WT2_5x9_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT2.5X9.5";
        public Length Height => new Length(2.58, LengthUnit.Inch);
        public Length Width => new Length(5.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.27, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.65, LengthUnit.Inch);

        public WT2_5x9_5() { }
    }
}
