using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W16x67 : SingletonAmericanBase<W16x67>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W16X67";
        public Length Height => new Length(16.30, LengthUnit.Inch);
        public Length Width => new Length(10.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.67, LengthUnit.Inch);
        public Length WebThickness => new Length(0.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.855, LengthUnit.Inch);

        public W16x67() { }
    }
}
