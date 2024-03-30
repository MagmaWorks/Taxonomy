using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x46 : SingletonAmericanBase<W18x46>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X46";
        public Length Height => new Length(18.10, LengthUnit.Inch);
        public Length Width => new Length(6.06, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.61, LengthUnit.Inch);
        public Length WebThickness => new Length(0.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.69, LengthUnit.Inch);

        public W18x46() { }
    }
}
