using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x168 : SingletonAmericanBase<WT13_5x168>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X168";
        public Length Height => new Length(15.00, LengthUnit.Inch);
        public Length Width => new Length(14.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.28, LengthUnit.Inch);
        public Length WebThickness => new Length(1.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.6, LengthUnit.Inch);

        public WT13_5x168() { }
    }
}
