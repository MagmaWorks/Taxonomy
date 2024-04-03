using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x22 : SingletonAmericanBase<W12x22>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X22";
        public Length Height => new Length(12.30, LengthUnit.Inch);
        public Length Width => new Length(4.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.5, LengthUnit.Inch);

        public W12x22() { }
    }
}
