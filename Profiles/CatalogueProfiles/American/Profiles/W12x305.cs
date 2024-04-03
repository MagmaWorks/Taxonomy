using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x305 : SingletonAmericanBase<W12x305>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X305";
        public Length Height => new Length(16.30, LengthUnit.Inch);
        public Length Width => new Length(13.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.71, LengthUnit.Inch);
        public Length WebThickness => new Length(1.63, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.815, LengthUnit.Inch);

        public W12x305() { }
    }
}
