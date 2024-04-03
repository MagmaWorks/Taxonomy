using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x45 : SingletonAmericanBase<W10x45>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X45";
        public Length Height => new Length(10.10, LengthUnit.Inch);
        public Length Width => new Length(8.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.62, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.635, LengthUnit.Inch);

        public W10x45() { }
    }
}
