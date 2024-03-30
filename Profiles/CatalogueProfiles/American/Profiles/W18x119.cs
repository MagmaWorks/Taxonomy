using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x119 : SingletonAmericanBase<W18x119>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X119";
        public Length Height => new Length(19.00, LengthUnit.Inch);
        public Length Width => new Length(11.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.06, LengthUnit.Inch);
        public Length WebThickness => new Length(0.66, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.875, LengthUnit.Inch);

        public W18x119() { }
    }
}
