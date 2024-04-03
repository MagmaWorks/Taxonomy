using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x44 : SingletonAmericanBase<WT5x44>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X44";
        public Length Height => new Length(5.42, LengthUnit.Inch);
        public Length Width => new Length(10.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.99, LengthUnit.Inch);
        public Length WebThickness => new Length(0.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.93, LengthUnit.Inch);

        public WT5x44() { }
    }
}
