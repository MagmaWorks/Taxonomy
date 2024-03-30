using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x19_5 : SingletonAmericanBase<WT5x19_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X19.5";
        public Length Height => new Length(4.96, LengthUnit.Inch);
        public Length Width => new Length(7.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.53, LengthUnit.Inch);
        public Length WebThickness => new Length(0.32, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.805, LengthUnit.Inch);

        public WT5x19_5() { }
    }
}
