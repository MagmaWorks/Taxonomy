using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x87_5 : SingletonAmericanBase<WT9x87_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X87.5";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(11.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.59, LengthUnit.Inch);
        public Length WebThickness => new Length(0.89, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.01, LengthUnit.Inch);

        public WT9x87_5() { }
    }
}
