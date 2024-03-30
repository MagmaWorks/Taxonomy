using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x487 : SingletonAmericanBase<W36x487>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X487";
        public Length Height => new Length(39.30, LengthUnit.Inch);
        public Length Width => new Length(17.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.68, LengthUnit.Inch);
        public Length WebThickness => new Length(1.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.28, LengthUnit.Inch);

        public W36x487() { }
    }
}
