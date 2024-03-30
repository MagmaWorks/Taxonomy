using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe3over4SCH40 : SingletonAmericanBase<Pipe3over4SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe3/4SCH40";
        public Length Diameter => new Length(1.05, LengthUnit.Inch);
        public Length Thickness => new Length(0.11, LengthUnit.Inch);

        public Pipe3over4SCH40() { }
    }
}
