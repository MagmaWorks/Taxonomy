using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x55 : SingletonAmericanBase<W21x55>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X55";
        public Length Height => new Length(20.80, LengthUnit.Inch);
        public Length Width => new Length(8.22, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.52, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.62, LengthUnit.Inch);

        public W21x55() { }
    }
}
