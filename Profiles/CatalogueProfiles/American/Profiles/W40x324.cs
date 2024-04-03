using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x324 : SingletonAmericanBase<W40x324>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X324";
        public Length Height => new Length(40.20, LengthUnit.Inch);
        public Length Width => new Length(15.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.81, LengthUnit.Inch);
        public Length WebThickness => new Length(1.00, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.19, LengthUnit.Inch);

        public W40x324() { }
    }
}
