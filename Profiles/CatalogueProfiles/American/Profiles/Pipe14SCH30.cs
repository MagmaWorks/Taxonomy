using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe14SCH30 : SingletonAmericanBase<Pipe14SCH30>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe14SCH30";
        public Length Diameter => new Length(14.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public Pipe14SCH30() { }
    }
}
