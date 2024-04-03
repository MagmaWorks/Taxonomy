using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x136 : SingletonAmericanBase<W12x136>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X136";
        public Length Height => new Length(13.40, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.79, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.855, LengthUnit.Inch);

        public W12x136() { }
    }
}
