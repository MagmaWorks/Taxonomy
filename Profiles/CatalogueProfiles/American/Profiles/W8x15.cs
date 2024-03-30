using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x15 : SingletonAmericanBase<W8x15>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X15";
        public Length Height => new Length(8.11, LengthUnit.Inch);
        public Length Width => new Length(4.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.32, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.485, LengthUnit.Inch);

        public W8x15() { }
    }
}
