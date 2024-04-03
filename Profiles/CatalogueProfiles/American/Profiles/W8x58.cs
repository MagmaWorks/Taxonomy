using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x58 : SingletonAmericanBase<W8x58>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X58";
        public Length Height => new Length(8.75, LengthUnit.Inch);
        public Length Width => new Length(8.22, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.81, LengthUnit.Inch);
        public Length WebThickness => new Length(0.51, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.625, LengthUnit.Inch);

        public W8x58() { }
    }
}
