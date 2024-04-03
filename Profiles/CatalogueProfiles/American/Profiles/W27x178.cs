using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x178 : SingletonAmericanBase<W27x178>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X178";
        public Length Height => new Length(27.80, LengthUnit.Inch);
        public Length Width => new Length(14.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.73, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.195, LengthUnit.Inch);

        public W27x178() { }
    }
}
