using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x655 : SingletonAmericanBase<W40x655>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X655";
        public Length Height => new Length(43.60, LengthUnit.Inch);
        public Length Width => new Length(16.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.54, LengthUnit.Inch);
        public Length WebThickness => new Length(1.97, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.26, LengthUnit.Inch);

        public W40x655() { }
    }
}
