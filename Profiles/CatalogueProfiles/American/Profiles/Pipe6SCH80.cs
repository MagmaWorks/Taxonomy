using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe6SCH80 : SingletonAmericanBase<Pipe6SCH80>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe6SCH80";
        public Length Diameter => new Length(6.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.43, LengthUnit.Inch);

        public Pipe6SCH80() { }
    }
}
