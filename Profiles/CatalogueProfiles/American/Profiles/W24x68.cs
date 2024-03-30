using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x68 : SingletonAmericanBase<W24x68>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X68";
        public Length Height => new Length(23.70, LengthUnit.Inch);
        public Length Width => new Length(8.97, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.59, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.26, LengthUnit.Inch);

        public W24x68() { }
    }
}
