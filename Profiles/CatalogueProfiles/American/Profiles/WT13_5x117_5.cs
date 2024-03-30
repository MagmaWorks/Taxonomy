using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x117_5 : SingletonAmericanBase<WT13_5x117_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X117.5";
        public Length Height => new Length(14.30, LengthUnit.Inch);
        public Length Width => new Length(14.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.61, LengthUnit.Inch);
        public Length WebThickness => new Length(0.91, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.245, LengthUnit.Inch);

        public WT13_5x117_5() { }
    }
}
