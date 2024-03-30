using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x60 : SingletonAmericanBase<W10x60>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X60";
        public Length Height => new Length(10.20, LengthUnit.Inch);
        public Length Width => new Length(10.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.68, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.67, LengthUnit.Inch);

        public W10x60() { }
    }
}
