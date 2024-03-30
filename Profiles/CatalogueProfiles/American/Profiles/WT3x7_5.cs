using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT3x7_5 : SingletonAmericanBase<WT3x7_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT3X7.5";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(5.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.37, LengthUnit.Inch);

        public WT3x7_5() { }
    }
}
