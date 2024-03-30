using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x83 : SingletonAmericanBase<W21x83>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X83";
        public Length Height => new Length(21.40, LengthUnit.Inch);
        public Length Width => new Length(8.36, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.84, LengthUnit.Inch);
        public Length WebThickness => new Length(0.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.67, LengthUnit.Inch);

        public W21x83() { }
    }
}
