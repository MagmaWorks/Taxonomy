using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W6x15 : SingletonAmericanBase<W6x15>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W6X15";
        public Length Height => new Length(5.99, LengthUnit.Inch);
        public Length Width => new Length(5.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.485, LengthUnit.Inch);

        public W6x15() { }
    }
}
