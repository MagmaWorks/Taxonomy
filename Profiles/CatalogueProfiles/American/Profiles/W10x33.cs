using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x33 : SingletonAmericanBase<W10x33>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X33";
        public Length Height => new Length(9.73, LengthUnit.Inch);
        public Length Width => new Length(7.96, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.605, LengthUnit.Inch);

        public W10x33() { }
    }
}
