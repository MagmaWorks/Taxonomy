using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x194 : SingletonAmericanBase<W36x194>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X194";
        public Length Height => new Length(36.50, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.77, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.24, LengthUnit.Inch);

        public W36x194() { }
    }
}
