using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe18xS : SingletonAmericanBase<Pipe18xS>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe18XS";
        public Length Diameter => new Length(18.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public Pipe18xS() { }
    }
}
