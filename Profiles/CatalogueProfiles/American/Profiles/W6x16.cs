using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W6x16 : SingletonAmericanBase<W6x16>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W6X16";
        public Length Height => new Length(6.28, LengthUnit.Inch);
        public Length Width => new Length(4.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.41, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.43, LengthUnit.Inch);

        public W6x16() { }
    }
}
