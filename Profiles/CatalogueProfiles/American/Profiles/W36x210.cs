using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x210 : SingletonAmericanBase<W36x210>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X210";
        public Length Height => new Length(36.70, LengthUnit.Inch);
        public Length Width => new Length(12.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W36x210() { }
    }
}
