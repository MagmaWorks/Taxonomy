using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe1over2SCH40 : SingletonAmericanBase<Pipe1over2SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe1/2SCH40";
        public Length Diameter => new Length(0.84, LengthUnit.Inch);
        public Length Thickness => new Length(0.11, LengthUnit.Inch);

        public Pipe1over2SCH40() { }
    }
}
