using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x730 : SingletonAmericanBase<W14x730>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X730";
        public Length Height => new Length(22.40, LengthUnit.Inch);
        public Length Width => new Length(17.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.91, LengthUnit.Inch);
        public Length WebThickness => new Length(3.07, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W14x730() { }
    }
}
