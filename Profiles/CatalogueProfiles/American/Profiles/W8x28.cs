using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x28 : SingletonAmericanBase<W8x28>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X28";
        public Length Height => new Length(8.06, LengthUnit.Inch);
        public Length Width => new Length(6.54, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.47, LengthUnit.Inch);
        public Length WebThickness => new Length(0.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.485, LengthUnit.Inch);

        public W8x28() { }
    }
}
