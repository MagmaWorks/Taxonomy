using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x55 : SingletonAmericanBase<W24x55>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X55";
        public Length Height => new Length(23.60, LengthUnit.Inch);
        public Length Width => new Length(7.01, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.51, LengthUnit.Inch);
        public Length WebThickness => new Length(0.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.915, LengthUnit.Inch);

        public W24x55() { }
    }
}
