using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x129 : SingletonAmericanBase<WT13_5x129>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X129";
        public Length Height => new Length(14.50, LengthUnit.Inch);
        public Length Width => new Length(14.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.77, LengthUnit.Inch);
        public Length WebThickness => new Length(0.98, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.1, LengthUnit.Inch);

        public WT13_5x129() { }
    }
}
