using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x269_5 : SingletonAmericanBase<WT13_5x269_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X269.5";
        public Length Height => new Length(16.30, LengthUnit.Inch);
        public Length Width => new Length(15.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.54, LengthUnit.Inch);
        public Length WebThickness => new Length(1.97, LengthUnit.Inch);
        public Length FilletRadius => new Length(11.97, LengthUnit.Inch);

        public WT13_5x269_5() { }
    }
}
