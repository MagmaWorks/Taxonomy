using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x130 : SingletonAmericanBase<W18x130>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X130";
        public Length Height => new Length(19.30, LengthUnit.Inch);
        public Length Width => new Length(11.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.20, LengthUnit.Inch);
        public Length WebThickness => new Length(0.67, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.855, LengthUnit.Inch);

        public W18x130() { }
    }
}
