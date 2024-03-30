using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x58 : SingletonAmericanBase<W12x58>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X58";
        public Length Height => new Length(12.20, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.64, LengthUnit.Inch);
        public Length WebThickness => new Length(0.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.835, LengthUnit.Inch);

        public W12x58() { }
    }
}
