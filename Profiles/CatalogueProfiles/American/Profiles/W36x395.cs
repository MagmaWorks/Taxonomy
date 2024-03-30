using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x395 : SingletonAmericanBase<W36x395>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X395";
        public Length Height => new Length(38.40, LengthUnit.Inch);
        public Length Width => new Length(16.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.20, LengthUnit.Inch);
        public Length WebThickness => new Length(1.22, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.31, LengthUnit.Inch);

        public W36x395() { }
    }
}
