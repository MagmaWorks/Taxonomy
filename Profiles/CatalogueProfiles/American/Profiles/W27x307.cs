using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x307 : SingletonAmericanBase<W27x307>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X307";
        public Length Height => new Length(29.60, LengthUnit.Inch);
        public Length Width => new Length(14.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.09, LengthUnit.Inch);
        public Length WebThickness => new Length(1.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.21, LengthUnit.Inch);

        public W27x307() { }
    }
}
