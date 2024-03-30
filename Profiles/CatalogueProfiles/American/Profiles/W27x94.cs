using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x94 : SingletonAmericanBase<W27x94>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X94";
        public Length Height => new Length(26.90, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.49, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.2, LengthUnit.Inch);

        public W27x94() { }
    }
}
