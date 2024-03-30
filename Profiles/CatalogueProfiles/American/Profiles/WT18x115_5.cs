using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x115_5 : SingletonAmericanBase<WT18x115_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X115.5";
        public Length Height => new Length(18.20, LengthUnit.Inch);
        public Length Width => new Length(16.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.76, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.66, LengthUnit.Inch);

        public WT18x115_5() { }
    }
}
