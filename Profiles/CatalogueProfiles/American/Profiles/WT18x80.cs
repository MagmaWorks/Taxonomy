using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x80 : SingletonAmericanBase<WT18x80>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X80";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.02, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.905, LengthUnit.Inch);

        public WT18x80() { }
    }
}
