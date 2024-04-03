using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x19 : SingletonAmericanBase<W12x19>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X19";
        public Length Height => new Length(12.20, LengthUnit.Inch);
        public Length Width => new Length(4.01, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.35, LengthUnit.Inch);
        public Length WebThickness => new Length(0.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.44, LengthUnit.Inch);

        public W12x19() { }
    }
}
