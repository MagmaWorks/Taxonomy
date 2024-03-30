using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W44x230 : SingletonAmericanBase<W44x230>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W44X230";
        public Length Height => new Length(42.90, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.22, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.23, LengthUnit.Inch);

        public W44x230() { }
    }
}
