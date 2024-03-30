using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x652 : SingletonAmericanBase<W36x652>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X652";
        public Length Height => new Length(41.10, LengthUnit.Inch);
        public Length Width => new Length(17.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.54, LengthUnit.Inch);
        public Length WebThickness => new Length(1.97, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.32, LengthUnit.Inch);

        public W36x652() { }
    }
}
