using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x38 : SingletonAmericanBase<W14x38>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X38";
        public Length Height => new Length(14.10, LengthUnit.Inch);
        public Length Width => new Length(6.77, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.52, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.655, LengthUnit.Inch);

        public W14x38() { }
    }
}
