using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x350 : SingletonAmericanBase<W36x350>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X350";
        public Length Height => new Length(38.60, LengthUnit.Inch);
        public Length Width => new Length(12.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.32, LengthUnit.Inch);
        public Length WebThickness => new Length(1.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.23, LengthUnit.Inch);

        public W36x350() { }
    }
}
