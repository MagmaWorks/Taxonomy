using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x217 : SingletonAmericanBase<W27x217>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X217";
        public Length Height => new Length(28.40, LengthUnit.Inch);
        public Length Width => new Length(14.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.2, LengthUnit.Inch);

        public W27x217() { }
    }
}
