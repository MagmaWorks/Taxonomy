using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x55 : SingletonAmericanBase<W18x55>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X55";
        public Length Height => new Length(18.10, LengthUnit.Inch);
        public Length Width => new Length(7.53, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.39, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.67, LengthUnit.Inch);

        public W18x55() { }
    }
}
