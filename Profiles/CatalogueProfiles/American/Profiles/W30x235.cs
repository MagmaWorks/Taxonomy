using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x235 : SingletonAmericanBase<W30x235>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X235";
        public Length Height => new Length(31.30, LengthUnit.Inch);
        public Length Width => new Length(15.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W30x235() { }
    }
}
