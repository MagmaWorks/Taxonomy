using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x17 : SingletonAmericanBase<W10x17>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X17";
        public Length Height => new Length(10.10, LengthUnit.Inch);
        public Length Width => new Length(4.01, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.33, LengthUnit.Inch);
        public Length WebThickness => new Length(0.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.53, LengthUnit.Inch);

        public W10x17() { }
    }
}
