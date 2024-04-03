using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W5x19 : SingletonAmericanBase<W5x19>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W5X19";
        public Length Height => new Length(5.15, LengthUnit.Inch);
        public Length Width => new Length(5.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.27, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.305, LengthUnit.Inch);

        public W5x19() { }
    }
}
