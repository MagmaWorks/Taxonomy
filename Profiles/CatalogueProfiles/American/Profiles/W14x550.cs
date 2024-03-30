using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x550 : SingletonAmericanBase<W14x550>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X550";
        public Length Height => new Length(20.20, LengthUnit.Inch);
        public Length Width => new Length(17.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.82, LengthUnit.Inch);
        public Length WebThickness => new Length(2.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.28, LengthUnit.Inch);

        public W14x550() { }
    }
}
