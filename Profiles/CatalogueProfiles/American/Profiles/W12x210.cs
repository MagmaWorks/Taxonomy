using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x210 : SingletonAmericanBase<W12x210>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X210";
        public Length Height => new Length(14.70, LengthUnit.Inch);
        public Length Width => new Length(12.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.90, LengthUnit.Inch);
        public Length WebThickness => new Length(1.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.85, LengthUnit.Inch);

        public W12x210() { }
    }
}
