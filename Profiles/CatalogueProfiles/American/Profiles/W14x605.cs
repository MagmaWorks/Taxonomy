using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x605 : SingletonAmericanBase<W14x605>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X605";
        public Length Height => new Length(20.90, LengthUnit.Inch);
        public Length Width => new Length(17.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.16, LengthUnit.Inch);
        public Length WebThickness => new Length(2.60, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.29, LengthUnit.Inch);

        public W14x605() { }
    }
}
