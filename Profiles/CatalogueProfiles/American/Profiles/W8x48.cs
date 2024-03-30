using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x48 : SingletonAmericanBase<W8x48>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X48";
        public Length Height => new Length(8.50, LengthUnit.Inch);
        public Length Width => new Length(8.11, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.69, LengthUnit.Inch);
        public Length WebThickness => new Length(0.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.685, LengthUnit.Inch);

        public W8x48() { }
    }
}
