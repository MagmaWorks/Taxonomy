using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x503 : SingletonAmericanBase<W40x503>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X503";
        public Length Height => new Length(42.10, LengthUnit.Inch);
        public Length Width => new Length(16.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.76, LengthUnit.Inch);
        public Length WebThickness => new Length(1.54, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.23, LengthUnit.Inch);

        public W40x503() { }
    }
}
