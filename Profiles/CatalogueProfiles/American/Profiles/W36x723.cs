using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x723 : SingletonAmericanBase<W36x723>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X723";
        public Length Height => new Length(41.80, LengthUnit.Inch);
        public Length Width => new Length(17.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.90, LengthUnit.Inch);
        public Length WebThickness => new Length(2.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.795, LengthUnit.Inch);

        public W36x723() { }
    }
}
