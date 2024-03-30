using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe3xxS : SingletonAmericanBase<Pipe3xxS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe3XXS";
        public Length Diameter => new Length(3.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.60, LengthUnit.Inch);

        public Pipe3xxS() { }
    }
}
