using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M8x6_5 : SingletonAmericanBase<M8x6_5>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M8X6.5";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(2.28, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.14, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.37, LengthUnit.Inch);

        public M8x6_5() { }
    }
}
