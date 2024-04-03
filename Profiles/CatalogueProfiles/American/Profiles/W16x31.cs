using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W16x31 : SingletonAmericanBase<W16x31>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W16X31";
        public Length Height => new Length(15.90, LengthUnit.Inch);
        public Length Width => new Length(5.53, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.28, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.61, LengthUnit.Inch);

        public W16x31() { }
    }
}
