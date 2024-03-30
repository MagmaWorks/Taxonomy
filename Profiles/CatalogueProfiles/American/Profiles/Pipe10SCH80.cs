using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe10SCH80 : SingletonAmericanBase<Pipe10SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe10SCH80";
        public Length Diameter => new Length(10.75, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public Pipe10SCH80() { }
    }
}
