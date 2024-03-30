using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x35_5 : SingletonAmericanBase<WT9x35_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X35.5";
        public Length Height => new Length(9.24, LengthUnit.Inch);
        public Length Width => new Length(7.64, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.81, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.36, LengthUnit.Inch);

        public WT9x35_5() { }
    }
}
