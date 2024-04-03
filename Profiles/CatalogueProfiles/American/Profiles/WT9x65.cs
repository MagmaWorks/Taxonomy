using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x65 : SingletonAmericanBase<WT9x65>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X65";
        public Length Height => new Length(9.63, LengthUnit.Inch);
        public Length Width => new Length(11.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.20, LengthUnit.Inch);
        public Length WebThickness => new Length(0.67, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.03, LengthUnit.Inch);

        public WT9x65() { }
    }
}
