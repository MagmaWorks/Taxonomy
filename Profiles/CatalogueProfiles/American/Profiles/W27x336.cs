using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x336 : SingletonAmericanBase<W27x336>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X336";
        public Length Height => new Length(30.00, LengthUnit.Inch);
        public Length Width => new Length(14.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.28, LengthUnit.Inch);
        public Length WebThickness => new Length(1.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.22, LengthUnit.Inch);

        public W27x336() { }
    }
}
