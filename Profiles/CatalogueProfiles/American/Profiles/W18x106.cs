using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x106 : SingletonAmericanBase<W18x106>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X106";
        public Length Height => new Length(18.70, LengthUnit.Inch);
        public Length Width => new Length(11.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.94, LengthUnit.Inch);
        public Length WebThickness => new Length(0.59, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.835, LengthUnit.Inch);

        public W18x106() { }
    }
}
