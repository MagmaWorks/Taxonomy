using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe4SCH80 : SingletonAmericanBase<Pipe4SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe4SCH80";
        public Length Diameter => new Length(4.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.34, LengthUnit.Inch);

        public Pipe4SCH80() { }
    }
}
