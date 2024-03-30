using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x56 : SingletonAmericanBase<WT5x56>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X56";
        public Length Height => new Length(5.68, LengthUnit.Inch);
        public Length Width => new Length(10.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.76, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.07, LengthUnit.Inch);

        public WT5x56() { }
    }
}
