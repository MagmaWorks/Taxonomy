using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x108 : SingletonAmericanBase<W30x108>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X108";
        public Length Height => new Length(29.80, LengthUnit.Inch);
        public Length Width => new Length(10.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.76, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.225, LengthUnit.Inch);

        public W30x108() { }
    }
}
