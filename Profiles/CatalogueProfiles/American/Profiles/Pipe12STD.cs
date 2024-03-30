using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe12STD : SingletonAmericanBase<Pipe12STD>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe12STD";
        public Length Diameter => new Length(12.75, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public Pipe12STD() { }
    }
}
