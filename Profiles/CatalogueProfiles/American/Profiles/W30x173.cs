using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x173 : SingletonAmericanBase<W30x173>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X173";
        public Length Height => new Length(30.40, LengthUnit.Inch);
        public Length Width => new Length(15.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.07, LengthUnit.Inch);
        public Length WebThickness => new Length(0.66, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.255, LengthUnit.Inch);

        public W30x173() { }
    }
}
