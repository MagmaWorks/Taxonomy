using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x24 : SingletonAmericanBase<W8x24>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X24";
        public Length Height => new Length(7.93, LengthUnit.Inch);
        public Length Width => new Length(6.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.40, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.435, LengthUnit.Inch);

        public W8x24() { }
    }
}
