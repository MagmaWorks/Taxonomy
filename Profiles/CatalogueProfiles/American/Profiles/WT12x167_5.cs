using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x167_5 : SingletonAmericanBase<WT12x167_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X167.5";
        public Length Height => new Length(13.80, LengthUnit.Inch);
        public Length Width => new Length(13.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.48, LengthUnit.Inch);
        public Length WebThickness => new Length(1.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.08, LengthUnit.Inch);

        public WT12x167_5() { }
    }
}
