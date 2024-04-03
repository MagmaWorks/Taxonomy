using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT22x204 : SingletonAmericanBase<WT22x204>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT22X204";
        public Length Height => new Length(22.40, LengthUnit.Inch);
        public Length Width => new Length(16.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.17, LengthUnit.Inch);
        public Length WebThickness => new Length(1.22, LengthUnit.Inch);
        public Length FilletRadius => new Length(19.44, LengthUnit.Inch);

        public WT22x204() { }
    }
}
