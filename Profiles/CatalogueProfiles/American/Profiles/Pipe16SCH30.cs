using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class Pipe16SCH30 : SingletonAmericanBase<Pipe16SCH30>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.Pipe;
        public override string Label => "Pipe16SCH30";
        public Length Diameter => new Length(16.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public Pipe16SCH30() { }
    }
}
