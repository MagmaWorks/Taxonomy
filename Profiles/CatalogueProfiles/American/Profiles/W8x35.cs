using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x35 : SingletonAmericanBase<W8x35>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X35";
        public Length Height => new Length(8.12, LengthUnit.Inch);
        public Length Width => new Length(8.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.685, LengthUnit.Inch);

        public W8x35() { }
    }
}
