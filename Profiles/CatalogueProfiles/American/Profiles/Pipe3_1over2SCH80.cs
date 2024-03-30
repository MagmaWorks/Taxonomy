using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe3_1over2SCH80 : SingletonAmericanBase<Pipe3_1over2SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe3-1/2SCH80";
        public Length Diameter => new Length(4.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.32, LengthUnit.Inch);

        public Pipe3_1over2SCH80() { }
    }
}
