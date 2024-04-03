using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x455 : SingletonAmericanBase<W14x455>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X455";
        public Length Height => new Length(19.00, LengthUnit.Inch);
        public Length Width => new Length(16.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.21, LengthUnit.Inch);
        public Length WebThickness => new Length(2.02, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.24, LengthUnit.Inch);

        public W14x455() { }
    }
}
