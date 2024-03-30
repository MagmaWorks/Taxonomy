using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe1_1over4SCH40 : SingletonAmericanBase<Pipe1_1over4SCH40>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe1-1/4SCH40";
        public Length Diameter => new Length(1.66, LengthUnit.Inch);
        public Length Thickness => new Length(0.14, LengthUnit.Inch);

        public Pipe1_1over4SCH40() { }
    }
}
