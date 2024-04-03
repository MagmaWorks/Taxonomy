using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe3SCH40 : SingletonAmericanBase<Pipe3SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe3SCH40";
        public Length Diameter => new Length(3.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.22, LengthUnit.Inch);

        public Pipe3SCH40() { }
    }
}
