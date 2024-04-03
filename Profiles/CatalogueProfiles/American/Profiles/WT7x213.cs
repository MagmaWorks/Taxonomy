using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x213 : SingletonAmericanBase<WT7x213>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X213";
        public Length Height => new Length(9.34, LengthUnit.Inch);
        public Length Width => new Length(16.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.04, LengthUnit.Inch);
        public Length WebThickness => new Length(1.88, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.71, LengthUnit.Inch);

        public WT7x213() { }
    }
}
