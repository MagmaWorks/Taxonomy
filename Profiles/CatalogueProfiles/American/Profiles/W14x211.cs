using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x211 : SingletonAmericanBase<W14x211>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X211";
        public Length Height => new Length(15.70, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.98, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.29, LengthUnit.Inch);

        public W14x211() { }
    }
}
