using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x87 : SingletonAmericanBase<W12x87>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X87";
        public Length Height => new Length(12.50, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.81, LengthUnit.Inch);
        public Length WebThickness => new Length(0.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.875, LengthUnit.Inch);

        public W12x87() { }
    }
}
