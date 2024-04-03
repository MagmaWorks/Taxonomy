using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x19 : SingletonAmericanBase<WT7x19>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X19";
        public Length Height => new Length(7.05, LengthUnit.Inch);
        public Length Width => new Length(6.77, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.52, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(6.13, LengthUnit.Inch);

        public WT7x19() { }
    }
}
