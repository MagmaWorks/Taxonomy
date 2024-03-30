using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x297 : SingletonAmericanBase<W40x297>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X297";
        public Length Height => new Length(39.80, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.65, LengthUnit.Inch);
        public Length WebThickness => new Length(0.93, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.25, LengthUnit.Inch);

        public W40x297() { }
    }
}
