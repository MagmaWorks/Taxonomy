using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x152 : SingletonAmericanBase<W12x152>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X152";
        public Length Height => new Length(13.70, LengthUnit.Inch);
        public Length Width => new Length(12.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.40, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.885, LengthUnit.Inch);

        public W12x152() { }
    }
}
