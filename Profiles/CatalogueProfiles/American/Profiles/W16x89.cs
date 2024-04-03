using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W16x89 : SingletonAmericanBase<W16x89>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W16X89";
        public Length Height => new Length(16.80, LengthUnit.Inch);
        public Length Width => new Length(10.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.53, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.795, LengthUnit.Inch);

        public W16x89() { }
    }
}
