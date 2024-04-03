using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x281 : SingletonAmericanBase<W27x281>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X281";
        public Length Height => new Length(29.30, LengthUnit.Inch);
        public Length Width => new Length(14.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.93, LengthUnit.Inch);
        public Length WebThickness => new Length(1.06, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.22, LengthUnit.Inch);

        public W27x281() { }
    }
}
