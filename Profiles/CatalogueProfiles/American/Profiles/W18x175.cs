using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x175 : SingletonAmericanBase<W18x175>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X175";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(11.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.59, LengthUnit.Inch);
        public Length WebThickness => new Length(0.89, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.805, LengthUnit.Inch);

        public W18x175() { }
    }
}
