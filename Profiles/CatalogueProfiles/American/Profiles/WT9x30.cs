using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x30 : SingletonAmericanBase<WT9x30>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X30";
        public Length Height => new Length(9.12, LengthUnit.Inch);
        public Length Width => new Length(7.56, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.70, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.02, LengthUnit.Inch);

        public WT9x30() { }
    }
}
