using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x106 : SingletonAmericanBase<W12x106>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X106";
        public Length Height => new Length(12.90, LengthUnit.Inch);
        public Length Width => new Length(12.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.99, LengthUnit.Inch);
        public Length WebThickness => new Length(0.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.825, LengthUnit.Inch);

        public W12x106() { }
    }
}
