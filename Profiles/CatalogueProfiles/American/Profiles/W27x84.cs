using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x84 : SingletonAmericanBase<W27x84>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X84";
        public Length Height => new Length(26.70, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.64, LengthUnit.Inch);
        public Length WebThickness => new Length(0.46, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.21, LengthUnit.Inch);

        public W27x84() { }
    }
}
