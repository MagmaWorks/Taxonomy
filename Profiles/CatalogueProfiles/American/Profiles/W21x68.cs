using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x68 : SingletonAmericanBase<W21x68>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X68";
        public Length Height => new Length(21.10, LengthUnit.Inch);
        public Length Width => new Length(8.27, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.69, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.665, LengthUnit.Inch);

        public W21x68() { }
    }
}
