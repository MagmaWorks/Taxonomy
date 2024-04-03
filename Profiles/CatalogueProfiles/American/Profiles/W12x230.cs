using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x230 : SingletonAmericanBase<W12x230>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X230";
        public Length Height => new Length(15.10, LengthUnit.Inch);
        public Length Width => new Length(12.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.07, LengthUnit.Inch);
        public Length WebThickness => new Length(1.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.855, LengthUnit.Inch);

        public W12x230() { }
    }
}
