using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe3SCH80 : SingletonAmericanBase<Pipe3SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe3SCH80";
        public Length Diameter => new Length(3.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.30, LengthUnit.Inch);

        public Pipe3SCH80() { }
    }
}
