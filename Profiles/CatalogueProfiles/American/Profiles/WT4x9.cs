using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x9 : SingletonAmericanBase<WT4x9>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X9";
        public Length Height => new Length(4.07, LengthUnit.Inch);
        public Length Width => new Length(5.25, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.33, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.44, LengthUnit.Inch);

        public WT4x9() { }
    }
}
