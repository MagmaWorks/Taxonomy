using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x62 : SingletonAmericanBase<W21x62>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X62";
        public Length Height => new Length(21.00, LengthUnit.Inch);
        public Length Width => new Length(8.24, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.62, LengthUnit.Inch);
        public Length WebThickness => new Length(0.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.61, LengthUnit.Inch);

        public W21x62() { }
    }
}
