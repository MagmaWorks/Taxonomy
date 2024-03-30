using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x529 : SingletonAmericanBase<W36x529>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X529";
        public Length Height => new Length(39.80, LengthUnit.Inch);
        public Length Width => new Length(17.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.91, LengthUnit.Inch);
        public Length WebThickness => new Length(1.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.3, LengthUnit.Inch);

        public W36x529() { }
    }
}
