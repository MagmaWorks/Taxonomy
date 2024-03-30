using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W6x8_5 : SingletonAmericanBase<W6x8_5>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W6X8.5";
        public Length Height => new Length(5.83, LengthUnit.Inch);
        public Length Width => new Length(3.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.20, LengthUnit.Inch);
        public Length WebThickness => new Length(0.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.465, LengthUnit.Inch);

        public W6x8_5() { }
    }
}
