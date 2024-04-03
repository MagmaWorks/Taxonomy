using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x130 : SingletonAmericanBase<W33x130>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X130";
        public Length Height => new Length(33.10, LengthUnit.Inch);
        public Length Width => new Length(11.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.86, LengthUnit.Inch);
        public Length WebThickness => new Length(0.58, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.21, LengthUnit.Inch);

        public W33x130() { }
    }
}
