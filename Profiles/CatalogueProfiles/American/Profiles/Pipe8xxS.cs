using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe8xxS : SingletonAmericanBase<Pipe8xxS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe8XXS";
        public Length Diameter => new Length(8.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.88, LengthUnit.Inch);

        public Pipe8xxS() { }
    }
}
