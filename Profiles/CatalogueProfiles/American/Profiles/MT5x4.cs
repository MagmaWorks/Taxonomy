using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT5x4 : SingletonAmericanBase<MT5x4>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT5X4";
        public Length Height => new Length(4.98, LengthUnit.Inch);
        public Length Width => new Length(2.69, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.18, LengthUnit.Inch);
        public Length WebThickness => new Length(0.14, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.42, LengthUnit.Inch);

        public MT5x4() { }
    }
}
