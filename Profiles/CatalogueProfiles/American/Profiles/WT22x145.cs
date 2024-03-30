using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT22x145 : SingletonAmericanBase<WT22x145>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT22X145";
        public Length Height => new Length(21.80, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.58, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.105, LengthUnit.Inch);

        public WT22x145() { }
    }
}
