using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W44x262 : SingletonAmericanBase<W44x262>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W44X262";
        public Length Height => new Length(43.30, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.42, LengthUnit.Inch);
        public Length WebThickness => new Length(0.79, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.23, LengthUnit.Inch);

        public W44x262() { }
    }
}
