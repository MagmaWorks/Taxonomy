using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe4SCH40 : SingletonAmericanBase<Pipe4SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe4SCH40";
        public Length Diameter => new Length(4.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.24, LengthUnit.Inch);

        public Pipe4SCH40() { }
    }
}
