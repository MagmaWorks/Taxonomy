using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x26 : SingletonAmericanBase<W10x26>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X26";
        public Length Height => new Length(10.30, LengthUnit.Inch);
        public Length Width => new Length(5.77, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.56, LengthUnit.Inch);

        public W10x26() { }
    }
}
