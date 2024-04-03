using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x94 : SingletonAmericanBase<W24x94>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X94";
        public Length Height => new Length(24.30, LengthUnit.Inch);
        public Length Width => new Length(9.07, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.18, LengthUnit.Inch);

        public W24x94() { }
    }
}
