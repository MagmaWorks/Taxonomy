using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x159 : SingletonAmericanBase<W14x159>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X159";
        public Length Height => new Length(15.00, LengthUnit.Inch);
        public Length Width => new Length(15.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.31, LengthUnit.Inch);

        public W14x159() { }
    }
}
