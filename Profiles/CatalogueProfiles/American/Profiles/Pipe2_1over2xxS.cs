using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe2_1over2xxS : SingletonAmericanBase<Pipe2_1over2xxS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe2-1/2XXS";
        public Length Diameter => new Length(2.88, LengthUnit.Inch);
        public Length Thickness => new Length(0.55, LengthUnit.Inch);

        public Pipe2_1over2xxS() { }
    }
}
