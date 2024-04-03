using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe1_1over2SCH80 : SingletonAmericanBase<Pipe1_1over2SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe1-1/2SCH80";
        public Length Diameter => new Length(1.90, LengthUnit.Inch);
        public Length Thickness => new Length(0.20, LengthUnit.Inch);

        public Pipe1_1over2SCH80() { }
    }
}
