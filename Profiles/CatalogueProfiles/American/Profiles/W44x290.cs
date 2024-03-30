using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W44x290 : SingletonAmericanBase<W44x290>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W44X290";
        public Length Height => new Length(43.60, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.58, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.22, LengthUnit.Inch);

        public W44x290() { }
    }
}
