using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x49 : SingletonAmericanBase<W10x49>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X49";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.34, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.69, LengthUnit.Inch);

        public W10x49() { }
    }
}
