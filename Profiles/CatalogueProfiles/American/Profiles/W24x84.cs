using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x84 : SingletonAmericanBase<W24x84>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X84";
        public Length Height => new Length(24.10, LengthUnit.Inch);
        public Length Width => new Length(9.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.77, LengthUnit.Inch);
        public Length WebThickness => new Length(0.47, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.28, LengthUnit.Inch);

        public W24x84() { }
    }
}
