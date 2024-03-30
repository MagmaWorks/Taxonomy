using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x40 : SingletonAmericanBase<W8x40>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X40";
        public Length Height => new Length(8.25, LengthUnit.Inch);
        public Length Width => new Length(8.07, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.69, LengthUnit.Inch);

        public W8x40() { }
    }
}
