using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x336 : SingletonAmericanBase<W12x336>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X336";
        public Length Height => new Length(16.80, LengthUnit.Inch);
        public Length Width => new Length(13.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.96, LengthUnit.Inch);
        public Length WebThickness => new Length(1.78, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.8, LengthUnit.Inch);

        public W12x336() { }
    }
}
