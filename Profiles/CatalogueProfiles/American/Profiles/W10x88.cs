using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x88 : SingletonAmericanBase<W10x88>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X88";
        public Length Height => new Length(10.80, LengthUnit.Inch);
        public Length Width => new Length(10.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.99, LengthUnit.Inch);
        public Length WebThickness => new Length(0.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.635, LengthUnit.Inch);

        public W10x88() { }
    }
}
