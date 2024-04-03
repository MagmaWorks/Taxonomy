using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x853 : SingletonAmericanBase<W36x853>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X853";
        public Length Height => new Length(43.10, LengthUnit.Inch);
        public Length Width => new Length(18.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.53, LengthUnit.Inch);
        public Length WebThickness => new Length(2.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.8, LengthUnit.Inch);

        public W36x853() { }
    }
}
