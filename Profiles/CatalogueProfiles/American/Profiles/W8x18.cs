using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x18 : SingletonAmericanBase<W8x18>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X18";
        public Length Height => new Length(8.14, LengthUnit.Inch);
        public Length Width => new Length(5.25, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.33, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.445, LengthUnit.Inch);

        public W8x18() { }
    }
}
