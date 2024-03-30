using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x30 : SingletonAmericanBase<W12x30>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X30";
        public Length Height => new Length(12.30, LengthUnit.Inch);
        public Length Width => new Length(6.52, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.645, LengthUnit.Inch);

        public W12x30() { }
    }
}
