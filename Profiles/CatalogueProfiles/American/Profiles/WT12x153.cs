using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x153 : SingletonAmericanBase<WT12x153>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X153";
        public Length Height => new Length(13.60, LengthUnit.Inch);
        public Length Width => new Length(13.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.28, LengthUnit.Inch);
        public Length WebThickness => new Length(1.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.82, LengthUnit.Inch);

        public WT12x153() { }
    }
}
