using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x48 : SingletonAmericanBase<W21x48>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X48";
        public Length Height => new Length(20.60, LengthUnit.Inch);
        public Length Width => new Length(8.14, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.68, LengthUnit.Inch);

        public W21x48() { }
    }
}
