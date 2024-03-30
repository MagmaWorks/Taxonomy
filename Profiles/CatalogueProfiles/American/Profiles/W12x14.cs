using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x14 : SingletonAmericanBase<W12x14>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X14";
        public Length Height => new Length(11.90, LengthUnit.Inch);
        public Length Width => new Length(3.97, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.23, LengthUnit.Inch);
        public Length WebThickness => new Length(0.20, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.53, LengthUnit.Inch);

        public W12x14() { }
    }
}
