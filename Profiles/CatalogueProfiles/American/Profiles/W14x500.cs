using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x500 : SingletonAmericanBase<W14x500>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X500";
        public Length Height => new Length(19.60, LengthUnit.Inch);
        public Length Width => new Length(17.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.50, LengthUnit.Inch);
        public Length WebThickness => new Length(2.19, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W14x500() { }
    }
}
