using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe20SCH20 : SingletonAmericanBase<Pipe20SCH20>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe20SCH20";
        public Length Diameter => new Length(20.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public Pipe20SCH20() { }
    }
}
