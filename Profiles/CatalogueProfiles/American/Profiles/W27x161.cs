using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x161 : SingletonAmericanBase<W27x161>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X161";
        public Length Height => new Length(27.60, LengthUnit.Inch);
        public Length Width => new Length(14.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.08, LengthUnit.Inch);
        public Length WebThickness => new Length(0.66, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.22, LengthUnit.Inch);

        public W27x161() { }
    }
}
