using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x22 : SingletonAmericanBase<W10x22>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X22";
        public Length Height => new Length(10.20, LengthUnit.Inch);
        public Length Width => new Length(5.75, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.51, LengthUnit.Inch);

        public W10x22() { }
    }
}
