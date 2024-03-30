using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x441 : SingletonAmericanBase<W36x441>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X441";
        public Length Height => new Length(38.90, LengthUnit.Inch);
        public Length Width => new Length(17.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.44, LengthUnit.Inch);
        public Length WebThickness => new Length(1.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.32, LengthUnit.Inch);

        public W36x441() { }
    }
}
