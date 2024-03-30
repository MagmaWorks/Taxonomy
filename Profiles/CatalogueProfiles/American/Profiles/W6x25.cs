using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W6x25 : SingletonAmericanBase<W6x25>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W6X25";
        public Length Height => new Length(6.38, LengthUnit.Inch);
        public Length Width => new Length(6.08, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.46, LengthUnit.Inch);
        public Length WebThickness => new Length(0.32, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.48, LengthUnit.Inch);

        public W6x25() { }
    }
}
