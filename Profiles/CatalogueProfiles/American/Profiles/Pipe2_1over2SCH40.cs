using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe2_1over2SCH40 : SingletonAmericanBase<Pipe2_1over2SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe2-1/2SCH40";
        public Length Diameter => new Length(2.88, LengthUnit.Inch);
        public Length Thickness => new Length(0.20, LengthUnit.Inch);

        public Pipe2_1over2SCH40() { }
    }
}
