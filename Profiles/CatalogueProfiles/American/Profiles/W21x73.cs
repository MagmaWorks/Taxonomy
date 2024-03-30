using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x73 : SingletonAmericanBase<W21x73>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X73";
        public Length Height => new Length(21.20, LengthUnit.Inch);
        public Length Width => new Length(8.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.74, LengthUnit.Inch);
        public Length WebThickness => new Length(0.46, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.67, LengthUnit.Inch);

        public W21x73() { }
    }
}
