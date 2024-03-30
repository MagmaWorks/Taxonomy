using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x357 : SingletonAmericanBase<W30x357>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X357";
        public Length Height => new Length(32.80, LengthUnit.Inch);
        public Length Width => new Length(15.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.24, LengthUnit.Inch);
        public Length WebThickness => new Length(1.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.285, LengthUnit.Inch);

        public W30x357() { }
    }
}
