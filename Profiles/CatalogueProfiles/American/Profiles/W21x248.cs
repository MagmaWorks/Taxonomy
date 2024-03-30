using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x248 : SingletonAmericanBase<W21x248>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X248";
        public Length Height => new Length(23.70, LengthUnit.Inch);
        public Length Width => new Length(12.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.99, LengthUnit.Inch);
        public Length WebThickness => new Length(1.10, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W21x248() { }
    }
}
