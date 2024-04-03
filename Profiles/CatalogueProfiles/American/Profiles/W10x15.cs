using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x15 : SingletonAmericanBase<W10x15>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X15";
        public Length Height => new Length(9.99, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.27, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.445, LengthUnit.Inch);

        public W10x15() { }
    }
}
