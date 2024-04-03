using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x65 : SingletonAmericanBase<W12x65>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X65";
        public Length Height => new Length(12.10, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.61, LengthUnit.Inch);
        public Length WebThickness => new Length(0.39, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.805, LengthUnit.Inch);

        public W12x65() { }
    }
}
