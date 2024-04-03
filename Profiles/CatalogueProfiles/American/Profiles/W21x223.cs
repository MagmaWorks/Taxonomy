using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x223 : SingletonAmericanBase<W21x223>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X223";
        public Length Height => new Length(23.40, LengthUnit.Inch);
        public Length Width => new Length(12.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.79, LengthUnit.Inch);
        public Length WebThickness => new Length(1.00, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.19, LengthUnit.Inch);

        public W21x223() { }
    }
}
