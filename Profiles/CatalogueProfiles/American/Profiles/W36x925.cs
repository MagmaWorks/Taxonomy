using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x925 : SingletonAmericanBase<W36x925>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X925";
        public Length Height => new Length(43.10, LengthUnit.Inch);
        public Length Width => new Length(18.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.53, LengthUnit.Inch);
        public Length WebThickness => new Length(3.02, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.83, LengthUnit.Inch);

        public W36x925() { }
    }
}
