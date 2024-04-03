using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x330 : SingletonAmericanBase<W36x330>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X330";
        public Length Height => new Length(37.70, LengthUnit.Inch);
        public Length Width => new Length(16.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.85, LengthUnit.Inch);
        public Length WebThickness => new Length(1.02, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.24, LengthUnit.Inch);

        public W36x330() { }
    }
}
