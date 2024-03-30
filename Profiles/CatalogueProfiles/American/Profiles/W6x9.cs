using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W6x9 : SingletonAmericanBase<W6x9>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W6X9";
        public Length Height => new Length(5.90, LengthUnit.Inch);
        public Length Width => new Length(3.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.22, LengthUnit.Inch);
        public Length WebThickness => new Length(0.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.48, LengthUnit.Inch);

        public W6x9() { }
    }
}
