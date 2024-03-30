using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x103_5 : SingletonAmericanBase<WT12x103_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X103.5";
        public Length Height => new Length(12.90, LengthUnit.Inch);
        public Length Width => new Length(13.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.995, LengthUnit.Inch);

        public WT12x103_5() { }
    }
}
