using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x48_5 : SingletonAmericanBase<WT9x48_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X48.5";
        public Length Height => new Length(9.30, LengthUnit.Inch);
        public Length Width => new Length(11.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.87, LengthUnit.Inch);
        public Length WebThickness => new Length(0.54, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.03, LengthUnit.Inch);

        public WT9x48_5() { }
    }
}
