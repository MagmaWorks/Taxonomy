using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x199 : SingletonAmericanBase<W40x199>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X199";
        public Length Height => new Length(38.70, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.07, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W40x199() { }
    }
}
