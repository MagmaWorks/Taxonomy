using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x40 : SingletonAmericanBase<W12x40>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X40";
        public Length Height => new Length(11.90, LengthUnit.Inch);
        public Length Width => new Length(8.01, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.52, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.73, LengthUnit.Inch);

        public W12x40() { }
    }
}
