using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x286 : SingletonAmericanBase<W36x286>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X286";
        public Length Height => new Length(37.80, LengthUnit.Inch);
        public Length Width => new Length(12.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.93, LengthUnit.Inch);
        public Length WebThickness => new Length(1.06, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.22, LengthUnit.Inch);

        public W36x286() { }
    }
}
