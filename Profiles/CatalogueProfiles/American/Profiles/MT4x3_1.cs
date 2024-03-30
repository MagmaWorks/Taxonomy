using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT4x3_1 : SingletonAmericanBase<MT4x3_1>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT4X3.1";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(2.28, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.18, LengthUnit.Inch);
        public Length WebThickness => new Length(0.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.635, LengthUnit.Inch);

        public MT4x3_1() { }
    }
}
