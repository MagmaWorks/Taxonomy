using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x76 : SingletonAmericanBase<WT16_5x76>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X76";
        public Length Height => new Length(16.70, LengthUnit.Inch);
        public Length Width => new Length(11.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.06, LengthUnit.Inch);
        public Length WebThickness => new Length(0.64, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.72, LengthUnit.Inch);

        public WT16_5x76() { }
    }
}
