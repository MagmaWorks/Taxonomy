using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x20 : SingletonAmericanBase<WT9x20>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X20";
        public Length Height => new Length(8.95, LengthUnit.Inch);
        public Length Width => new Length(6.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.53, LengthUnit.Inch);
        public Length WebThickness => new Length(0.32, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.02, LengthUnit.Inch);

        public WT9x20() { }
    }
}
