using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT4x3_25 : SingletonAmericanBase<MT4x3_25>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT4X3.25";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(2.28, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.14, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.51, LengthUnit.Inch);

        public MT4x3_25() { }
    }
}
