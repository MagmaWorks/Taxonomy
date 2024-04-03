using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x539 : SingletonAmericanBase<W27x539>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X539";
        public Length Height => new Length(32.50, LengthUnit.Inch);
        public Length Width => new Length(15.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.54, LengthUnit.Inch);
        public Length WebThickness => new Length(1.97, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.825, LengthUnit.Inch);

        public W27x539() { }
    }
}
