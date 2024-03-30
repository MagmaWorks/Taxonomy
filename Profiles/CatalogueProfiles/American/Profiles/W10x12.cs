using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x12 : SingletonAmericanBase<W10x12>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X12";
        public Length Height => new Length(9.87, LengthUnit.Inch);
        public Length Width => new Length(3.96, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.21, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.535, LengthUnit.Inch);

        public W10x12() { }
    }
}
