using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W4x13 : SingletonAmericanBase<W4x13>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W4X13";
        public Length Height => new Length(4.16, LengthUnit.Inch);
        public Length Width => new Length(4.06, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.35, LengthUnit.Inch);
        public Length WebThickness => new Length(0.28, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.415, LengthUnit.Inch);

        public W4x13() { }
    }
}
