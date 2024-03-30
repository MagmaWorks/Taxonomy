using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x18 : SingletonAmericanBase<WT8x18>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X18";
        public Length Height => new Length(7.93, LengthUnit.Inch);
        public Length Width => new Length(6.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.515, LengthUnit.Inch);

        public WT8x18() { }
    }
}
