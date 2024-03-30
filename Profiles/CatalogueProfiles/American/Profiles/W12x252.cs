using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x252 : SingletonAmericanBase<W12x252>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X252";
        public Length Height => new Length(15.40, LengthUnit.Inch);
        public Length Width => new Length(13.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.25, LengthUnit.Inch);
        public Length WebThickness => new Length(1.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.885, LengthUnit.Inch);

        public W12x252() { }
    }
}
