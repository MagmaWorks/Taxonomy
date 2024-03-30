using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x77 : SingletonAmericanBase<W10x77>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X77";
        public Length Height => new Length(10.60, LengthUnit.Inch);
        public Length Width => new Length(10.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.87, LengthUnit.Inch);
        public Length WebThickness => new Length(0.53, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.68, LengthUnit.Inch);

        public W10x77() { }
    }
}
