using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x10 : SingletonAmericanBase<W8x10>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X10";
        public Length Height => new Length(7.89, LengthUnit.Inch);
        public Length Width => new Length(3.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.21, LengthUnit.Inch);
        public Length WebThickness => new Length(0.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.485, LengthUnit.Inch);

        public W8x10() { }
    }
}
