using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x25 : SingletonAmericanBase<WT8x25>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X25";
        public Length Height => new Length(8.13, LengthUnit.Inch);
        public Length Width => new Length(7.07, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.315, LengthUnit.Inch);

        public WT8x25() { }
    }
}
