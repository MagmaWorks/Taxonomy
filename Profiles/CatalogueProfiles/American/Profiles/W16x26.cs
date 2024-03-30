using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W16x26 : SingletonAmericanBase<W16x26>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W16X26";
        public Length Height => new Length(15.70, LengthUnit.Inch);
        public Length Width => new Length(5.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.35, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.685, LengthUnit.Inch);

        public W16x26() { }
    }
}
