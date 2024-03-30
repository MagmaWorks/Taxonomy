using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x243_5 : SingletonAmericanBase<WT18x243_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X243.5";
        public Length Height => new Length(19.70, LengthUnit.Inch);
        public Length Width => new Length(17.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.68, LengthUnit.Inch);
        public Length WebThickness => new Length(1.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.17, LengthUnit.Inch);

        public WT18x243_5() { }
    }
}
