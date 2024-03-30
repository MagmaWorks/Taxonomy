using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x34 : SingletonAmericanBase<W14x34>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X34";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(6.75, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.46, LengthUnit.Inch);
        public Length WebThickness => new Length(0.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.725, LengthUnit.Inch);

        public W14x34() { }
    }
}
