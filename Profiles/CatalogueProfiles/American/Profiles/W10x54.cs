using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x54 : SingletonAmericanBase<W10x54>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X54";
        public Length Height => new Length(10.10, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.62, LengthUnit.Inch);
        public Length WebThickness => new Length(0.37, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.68, LengthUnit.Inch);

        public W10x54() { }
    }
}
